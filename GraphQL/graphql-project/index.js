const { ApolloServer, gql } = require("apollo-server");
const { ApolloServerPluginLandingPageGraphQLPlayground,} = require("apollo-server-core");

const typeDefs = gql`
  type Book {
    id: ID!
    title: String!
    author: String!
    score: Float
    isPublished: Boolean
  }

  type Query {
    books: [Book!]!
  }
`;

const books = [
  {
    id:"adaserwqqeqwefdsf132",
    title: "The Awakening",
    author: "Kate Chopin",
    score:5.8,
    isPublished:true
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
