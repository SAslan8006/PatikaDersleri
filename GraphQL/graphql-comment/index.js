const { ApolloServer, gql } = require('apollo-server-express');
const { createServer } = require('http');
const express = require('express');
const { ApolloServerPluginDrainHttpServer, ApolloServerPluginLandingPageGraphQLPlayground } = require('apollo-server-core');
const { makeExecutableSchema } = require('@graphql-tools/schema');
const { WebSocketServer } = require('ws');
const { useServer } = require('graphql-ws/lib/use/ws');
const { PubSub, withFilter } = require('graphql-subscriptions');
const { v4: uuidv4 } = require('uuid');

const { events, locations, users, participants } = require('./data.json');
const pubsub = require('./pubsup');

const app = express();
const httpServer = createServer(app);

const typeDefs = gql`
  # Event
  type Event {
    id: ID!
    title: String!
    desc: String!
    date: String!
    from: String!
    to: String!
    location_id: ID!
    user_id: ID!
    location: Location!
    user: User!
    participants: [Participant!]!
  }

  input createEvent {
    title: String!
    desc: String!
    date: String!
    from: String!
    to: String!
    location_id: ID!
    user_id: ID!
  }

  input updateEvent {
    title: String
    desc: String
    date: String
    from: String
    to: String
    location_id: ID
    user_id: ID
  }

  # Location
  type Location {
    id: ID!
    name: String!
    desc: String!
    lat: Float!
    lng: Float!
  }

  input createLocation {
    name: String!
    desc: String!
    lat: Float!
    lng: Float!
  }

  input updateLocation {
    name: String
    desc: String
    lat: Float
    lng: Float
  }

  # User
  type User {
    id: ID!
    username: String!
    email: String!
    events: [Event!]!
  }

  input createUser {
    username: String!
    email: String!
  }

  input updateUser {
    username: String
    email: String
  }

  # Participant
  type Participant {
    id: ID!
    user_id: ID!
    event_id: ID!
  }

  input createParticipant {
    user_id: ID!
    event_id: ID!
  }

  input updateParticipant {
    user_id: ID
    event_id: ID
  }

  type DeleteAllOutput {
    count: Int!
  }

  type Query {
    # Event
    events: [Event!]!
    event(id: ID!): Event!

    # Location
    locations: [Location!]!
    location(id: ID!): Location!

    # User
    users: [User!]!
    user(id: ID!): User!

    # Participant
    participants: [Participant!]!
    participant(id: ID!): Participant!
  }

  type Mutation {
    # Event
    createEvent(data: createEvent!): Event!
    updateEvent(id: ID!, data: updateEvent!): Event!
    deleteEvent(id: ID!): Event!
    deleteAllEvents: DeleteAllOutput!

    # Location
    createLocation(data: createLocation!): Location!
    updateLocation(id: ID!, data: updateLocation!): Location!
    deleteLocation(id: ID!): Location!
    deleteAllLocations: DeleteAllOutput!

    # User
    createUser(data: createUser!): User!
    updateUser(id: ID!, data: updateUser!): User!
    deleteUser(id: ID!): User!
    deleteAllUsers: DeleteAllOutput!

    # Participant
    createParticipant(data: createParticipant!): Participant!
    updateParticipant(id: ID!, data: updateParticipant!): Participant!
    deleteParticipant(id: ID!): Participant!
    deleteAllParticipants: DeleteAllOutput!
  }

  type Subscription {
    # Event
    eventCreated(user_id: ID): Event!
    eventUpdated: Event!
    eventDeleted: Event!
    eventCount: Int!

    # Location
    locationCreated: Location!
    locationUpdated: Location!
    locationDeleted: Location!
    locationCount: Int!

    # User
    userCreated: User!
    userUpdated: User!
    userDeleted: User!
    userCount: Int!

    # Participant
    participantCreated: Participant!
    participantUpdated: Participant!
    participantDeleted: Participant!
    participantCount: Int!
  }
`;

const resolvers = {
  Event: {
    location: (parent) => locations.find((location) => location.id === parent.location_id),
    user: (parent) => users.find((user) => user.id === parent.user_id),
    participants: (parent) => participants.filter((participant) => participant.event_id === parent.id),
  },

  User: {
    events: (parent) => events.filter((event) => event.user_id === parent.id),
  },

  Query: {
    // Event
    events: () => events,
    event: (parent, args) => events.find((event) => event.id == args.id),

    // Location
    locations: () => locations,
    location: (parent, args) => locations.find((location) => location.id == args.id),

    // User
    users: () => users,
    user: (parent, args) => users.find((user) => user.id == args.id),

    // Participant
    participants: () => participants,
    participant: (parent, args) => participants.find((participant) => participant.id == args.id),
  },

  Mutation: {
    // Event
    createEvent: (_, { data }, { pubsub }) => {
      const event = {
        id: uuidv4(),
        ...data,
      };
      events.push(event);
      pubsub.publish('eventCreated', { eventCreated: event });
      pubsub.publish('eventCount', { eventCount: events.length });
      return event;
    },
    updateEvent: (_, { id, data }, { pubsub }) => {
      const event_index = events.findIndex((event) => event.id == id);
      if (event_index === -1) {
        throw new Error('Event not found!');
      }
      const updated_event = (events[event_index] = {
        ...events[event_index],
        ...data,
      });
      pubsub.publish('eventUpdated', { eventUpdated: updated_event });
      return updated_event;
    },
    deleteEvent: (_, { id }, { pubsub }) => {
      const event_index = events.findIndex((event) => event.id == id);
      if (event_index === -1) {
        throw new Error('Event not found!');
      }
      const deleted_event = events[event_index];
      events.splice(event_index, 1);
      pubsub.publish('eventDeleted', { eventDeleted: deleted_event });
      pubsub.publish('eventCount', { eventCount: events.length });
      return deleted_event;
    },
    deleteAllEvents: () => {
      const length = events.length;
      events.splice(0, length);
      pubsub.publish('eventCount', { eventCount: events.length });
      return { count: length };
    },

    // Location
    createLocation: (_, { data }, { pubsub }) => {
      const location = {
        id: uuidv4(),
        ...data,
      };
      locations.push(location);
      pubsub.publish('locationCreated', { locationCreated: location });
      pubsub.publish('locationCount', { locationCount: locations.length });
      return location;
    },
    updateLocation: (_, { id, data }, { pubsub }) => {
      const location_index = locations.findIndex((location) => location.id == id);
      if (location_index === -1) {
        throw new Error('Location not found!');
      }
      const updated_location = (locations[location_index] = {
        ...locations[location_index],
        ...data,
      });
      pubsub.publish('locationUpdated', { locationUpdated: updated_location });
      return updated_location;
    },
    deleteLocation: (_, { id }, { pubsub }) => {
      const location_index = locations.findIndex((location) => location.id == id);
      if (location_index === -1) {
        throw new Error('Location not found!');
      }
      const deleted_location = locations[location_index];
      locations.splice(location_index, 1);
      pubsub.publish('locationDeleted', { locationDeleted: deleted_location });
      pubsub.publish('locationCount', { locationCount: locations.length });
      return deleted_location;
    },
    deleteAllLocations: () => {
      const length = locations.length;
      locations.splice(0, length);
      pubsub.publish('locationCount', { locationCount: locations.length });
      return { count: length };
    },

    // User
    createUser: (_, { data }, { pubsub }) => {
      const user = {
        id: uuidv4(),
        ...data,
      };
      users.push(user);
      pubsub.publish('userCreated', { userCreated: user });
      pubsub.publish('userCount', { userCount: users.length });
      return user;
    },
    updateUser: (_, { id, data }, { pubsub }) => {
      const user_index = users.findIndex((user) => user.id == id);
      if (user_index === -1) {
        throw new Error('User not found!');
      }
      const updated_user = (users[user_index] = {
        ...users[user_index],
        ...data,
      });
      pubsub.publish('userUpdated', { userUpdated: updated_user });
      return updated_user;
    },
    deleteUser: (_, { id }, { pubsub }) => {
      const user_index = users.findIndex((user) => user.id == id);
      if (user_index === -1) {
        throw new Error('User not found!');
      }
      const deleted_user = users[user_index];
      users.splice(user_index, 1);
      pubsub.publish('userDeleted', { userDeleted: deleted_user });
      pubsub.publish('userCount', { userCount: users.length });
      return deleted_user;
    },
    deleteAllUsers: () => {
      const length = users.length;
      users.splice(0, length);
      pubsub.publish('userCount', { userCount: users.length });
      return { count: length };
    },

    // Participant
    createParticipant: (_, { data }, { pubsub }) => {
      const participant = {
        id: uuidv4(),
        ...data,
      };
      participants.push(participant);
      pubsub.publish('participantCreated', { participantCreated: participant });
      pubsub.publish('participantCount', { participantCount: participants.length });
      return participant;
    },
    updateParticipant: (_, { id, data }, { pubsub }) => {
      const participant_index = participants.findIndex((participant) => participant.id == id);
      if (participant_index === -1) {
        throw new Error('Participant not found!');
      }
      const updated_participant = (participants[participant_index] = {
        ...participants[participant_index],
        ...data,
      });
      pubsub.publish('participantUpdated', { participantUpdated: updated_participant });
      return updated_participant;
    },
    deleteParticipant: (_, { id }, { pubsub }) => {
      const participant_index = participants.findIndex((participant) => participant.id == id);
      if (participant_index === -1) {
        throw new Error('Participant not found!');
      }
      const deleted_participant = participants[participant_index];
      participants.splice(participant_index, 1);
      pubsub.publish('participantDeleted', { participantDeleted: deleted_participant });
      pubsub.publish('participantCount', { participantCount: participants.length });
      return deleted_participant;
    },
    deleteAllParticipants: () => {
      const length = participants.length;
      participants.splice(0, length);
      pubsub.publish('participantCount', { participantCount: participants.length });
      return { count: length };
    },
  },

  Subscription: {
    // Event
    eventCreated: {
      subscribe: withFilter(
        (_, __, { pubsub }) => pubsub.asyncIterator('eventCreated'),
        (payload, variables) => {
          return variables.user_id ? payload.eventCreated.user_id === variables.user_id : true;
        }
      ),
    },
    eventUpdated: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('eventUpdated'),
    },
    eventDeleted: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('eventDeleted'),
    },
    eventCount: {
      subscribe: (_, __, { pubsub }) => {
        setTimeout(() => {
          pubsub.publish('eventCount', { eventCount: events.length });
        });
        return pubsub.asyncIterator('eventCount');
      },
    },

    // Location
    locationCreated: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('locationCreated'),
    },
    locationUpdated: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('locationUpdated'),
    },
    locationDeleted: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('locationDeleted'),
    },
    locationCount: {
      subscribe: (_, __, { pubsub }) => {
        setTimeout(() => {
          pubsub.publish('locationCount', { locationCount: locations.length });
        });
        return pubsub.asyncIterator('locationCount');
      },
    },

    // User
    userCreated: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('userCreated'),
    },
    userUpdated: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('userUpdated'),
    },
    userDeleted: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('userDeleted'),
    },
    userCount: {
      subscribe: (_, __, { pubsub }) => {
        setTimeout(() => {
          pubsub.publish('userCount', { userCount: users.length });
        });
        return pubsub.asyncIterator('userCount');
      },
    },

    // Participant
    participantCreated: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('participantCreated'),
    },
    participantUpdated: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('participantUpdated'),
    },
    participantDeleted: {
      subscribe: (_, __, { pubsub }) => pubsub.asyncIterator('participantDeleted'),
    },
    participantCount: {
      subscribe: (_, __, { pubsub }) => {
        setTimeout(() => {
          pubsub.publish('participantCount', { participantCount: participants.length });
        });
        return pubsub.asyncIterator('participantCount');
      },
    },
  },
};

const schema = makeExecutableSchema({ typeDefs, resolvers });

const wsServer = new WebSocketServer({
  server: httpServer,
  path: '/graphql',
});

const serverCleanup = useServer({ schema }, wsServer);

const server = new ApolloServer({
  schema,
  csrfPrevention: true,
  cache: 'bounded',
  plugins: [
    ApolloServerPluginDrainHttpServer({ httpServer }),
    ApolloServerPluginLandingPageGraphQLPlayground({}),
    {
      async serverWillStart() {
        return {
          async drainServer() {
            await serverCleanup.dispose();
          },
        };
      },
    },
  ],
});

async function serverStart() {
  await server.start();
  server.applyMiddleware({ app });

  const PORT = 4000;
  httpServer.listen(PORT, () => {
    console.log(`🚀 Query endpoint ready at http://localhost:${PORT}${server.graphqlPath}`);
    console.log(`🚀 Subscription endpoint ready at ws://localhost:${PORT}${server.graphqlPath}`);
  });
}

serverStart();