const { ApolloServer, gql } = require("apollo-server");
const {  ApolloServerPluginLandingPageGraphQLPlayground,} = require("apollo-server-core");
const { events, users, participants, locations } = require("./data.json");

const typeDefs = gql`
  type Event {
    id: ID!
    title: String!
    desc: String!
    data: String!
    to: String!
    location_id: Int!
    user_id: ID!
    users: [User!]!
    participants: [Participant!]!
    locations: [Location!]!
  }
  type User {
    id: ID!
    username: String!
    email: String!
  }
  type Participant {
    id: ID!
    user_id: ID!
    event_id: ID!
  }
  type Location {
    id: ID!
    name: String!
    desc: String!
    lat: Float!
    lng: Float!
  }
  type Query {
    #Events
    events: [Event!]!
    event(id: ID!): Event!
    #Users
    users: [User!]!
    user(id: ID!): User!
    #Participants
    participants: [Participant!]!
    participant(id: ID!): Participant!
    #Locations
    locations: [Location!]!
    location(id: ID!): Location!
  }
`;

const resolvers = {
  Query: {
    events: () => events,
    event: (parent, args) => events.find((event) => event.id === parseInt(args.id)),
    //
    users: () => users,
    user: (parent, args) => users.find((user) => user.id === parseInt(args.id)),
    //
    participants: () => participants,
    participant: (parent, args) =>  participants.find((participant) => participant.id === parseInt(args.id)),
    //
    locations: () => locations,
    location: (parent, args) =>
      locations.find((location) => location.id === parseInt(args.id)),
  },
  Event: {
    users: (parent, args) =>
      users.filter((user) => user.id === parseInt(parent.id)),
    //
    participants: (parent, args) => participants.filter(  (participant) => participant.id === parseInt(parent.id)
      ),
    //
    locations: (parent, args) =>
      locations.filter((location) => location.id === parseInt(parent.id)),
  },
};

const server = new ApolloServer({
  typeDefs,
  resolvers,
  plugins: [ApolloServerPluginLandingPageGraphQLPlayground({})],
});

server.listen().then(({ url }) => console.log(`GrapQL server is up ${url}`));