const { ApolloServer, gql } = require("apollo-server");
const {
  ApolloServerPluginLandingPageGraphQLPlayground,
} = require("apollo-server-core");

const author = {
  id: "1",
  name: "Albert",
  surname: "Camus",
  age: 50,
  books: [{ id: "1", title: "Test Title", score: 9, isPublished: false },{ id: "2", title: "Test Title", score: 9, isPublished: false },],
};

const books = {
  id: "adaserwqqeqwefdsf132",
  title: "The Awakening",
  author,
  score: 5.8,
  isPublished: true,
};

const typeDefs = gql`
  type Author {
    id: ID!
    name: String!
    surname: String
    age: Int
    books: [Book!]
  }
  type Book {
    id: ID!
    title: String!
    author: Author!
    score: Float
    isPublished: Boolean
  }

  type Query {
    books: Book
    author: Author
  }
`;

const resolvers = {
  Query: {
    books: () => books,
    author: () => author,
  },
};

const server = new ApolloServer({
  typeDefs,
  resolvers,
  plugins: [ApolloServerPluginLandingPageGraphQLPlayground()],
});

server.listen().then(({ url }) => {
  console.log(`🚀  Server ready at ${url}`);
});
