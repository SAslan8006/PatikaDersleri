const { ApolloServer, gql } = require("apollo-server");
const { ApolloServerPluginLandingPageGraphQLPlayground,} = require("apollo-server-core");

const typeDefs = gql`
  type Book {
    title: String!
    author: String!
  }

  type Query {
    books: [Book]
  }
`;

const books = [
  {
    title: "The Awakening",
    author: "Kate Chopin",
  },
  {
    title: "City of Glass",
    author: "Paul Auster",
  },
];

const resolvers = {
  Query: {
    books: () => books,
  },
};

const server = new ApolloServer({ typeDefs, resolvers ,plugins: [ApolloServerPluginLandingPageGraphQLPlayground()],});

server.listen().then(({ url }) => {
  console.log(`🚀  Server ready at ${url}`);
});
