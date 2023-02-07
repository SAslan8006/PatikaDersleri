const { ApolloServer, gql } = require('apollo-server');
const { ApolloServerPluginLandingPageGraphQLPlayground} = require('apollo-server-core');
const { authors, books} = require ('./data.js')


const typeDefs = gql`
  type Author {
    id: ID!
    name: String!
    surname: String!
    age: Int
    books(filter: String): [Book!]
  }

  type Book {
    id: ID!
    title: String!
    author: Author
    author_id: String!
    score: Float
    isPublished: Boolean!
  }

  type Query {
    books: [Book!]
    book(id: ID!) : Book! 

    authors: [Author!]
    author(id: ID!) : Author!
  }
`;

const resolvers = {
  Query: {
    books: () => books,
    book: (parent, args) => books.find( book => book.id === args.id),

    authors : () => authors,
    author: (parent, args) => authors.find( author => author.id === args.id),
  },

  Book: {
    author: (parent) => authors.find(author => author.id == parent.author_id),
  },
  
  Author: {
    books: (parent, args) =>  books.filter (book =>  {
      let filtered = book.author_id === parent.id && book.title.startsWith( args.filter || "");

      if(args.filter){
        filtered = book.author_id === parent.id && book.title.toLowerCase().startsWith( args.filter.toLowerCase() || "" );
      }
      return filtered
    }),
  },
};

const server = new ApolloServer({
  typeDefs,
  resolvers,
  plugins: [ApolloServerPluginLandingPageGraphQLPlayground()],
});

server.listen().then(({ url }) => {
  console.log('apollo server başaladı' + url);
});