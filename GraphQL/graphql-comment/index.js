const { ApolloServer, gql } = require("apollo-server");
const {
  ApolloServerPluginLandingPageGraphQLPlayground,
} = require("apollo-server-core");
const { users, posts, comments } = require("./data");

const typeDefs = gql`
  # User
  type User {
    id: ID!
    fullname: String!
    posts: [Post!]!
    comments: [Comment!]!
  }

  input CreateUserInput{
    fullname: String!
  }

  # Post
  type Post {
    id: ID!
    title: String!
    user_id: ID!
    user: User!
    comments: [Comment!]!
  }
  input CreatePostInput{
    title:String!
    user_id:ID!
  }

  # Comment
  type Comment {
    id: ID!
    text: String!
    post_id: ID!
    user: User!
    post: Post!
  }

  input CreateCommentInput{
    text:String!
    post_id: ID!
    user_id:ID!
  }

  # Query
  type Query {
    users: [User!]!
    user(id: ID!): User!
    posts: [Post!]!
    post(id: ID!): Post!
    comments: [Comment!]!
    comment(id: ID!): Comment!
  }

  # Mutation
  type Mutation {
    createUser(data:CreateUserInput!): User!
    creatPost(data:CreatePostInput!):Post!
    createComment(data:CreateCommentInput!):Comment!
  }
`;

const uid = function () {
  return Date.now().toString(36) + Math.random().toString(36).substr(2);
};

const resolvers = {
  Mutation: {
    createUser: (parent, args) => {
      const user={ id: uid(), fullname: args.data.fullname };
      users.push(user);
      return user;
    },
    creatPost: (parent,{data})=>{
      const post={ id: uid(), ...data};
      posts.push(post);
      return post;
    },
    createComment: (parent,{data})=>{
      const comment={ id: uid(), ...data };
      comments.push(comment);
      return comment;
    }
  },

  Query: {
    //Get All Users
    users: () => users,
    //Get Single User by ID
    user: (parent, args) => {
      const user = users.find((user) => user.id === args.id);
      if (!user) {
        throw "User not found";
      }
      return user;
    },

    posts: () => posts,
    post: (parent, args) => posts.find((post) => post.id === args.id),

    comments: () => comments,
    comment: (parent, args) =>
      comments.find((comment) => comment.id === args.id),
  },

  User: {
    posts: (parent, args) => posts.filter((post) => post.user_id === parent.id),
    comments: (parent, args) =>
      comments.filter((comment) => comment.user_id === parent.id),
  },

  Post: {
    user: (parent, args) => users.find((user) => user.id === parent.user_id),
    comments: (parent) =>
      comments.filter((comment) => comment.post_id === parent.id),
  },

  Comment: {
    user: (parent, args) => users.find((user) => user.id === parent.user_id),
    post: (parent, args) => posts.find((post) => post.id === parent.post_id),
  },
};

const server = new ApolloServer({
  typeDefs,
  resolvers,
  plugins: [ApolloServerPluginLandingPageGraphQLPlayground({})],
});

server.listen().then(({ url }) => console.log(`Apollo server ready at ${url}`));
