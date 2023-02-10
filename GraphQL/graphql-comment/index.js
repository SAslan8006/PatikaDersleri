const {GraphQLServer,PubSub}=require('graphql-yoga');
const { users, posts, comments } = require("./data");

const typeDefs = `
  # User
  type User {
    id: ID!
    fullname: String!
    age: Int!
    posts: [Post!]!
    comments: [Comment!]!
  }

  input CreateUserInput {
    fullname: String!
    age: Int!
  }

  input UpdateUserInput {
    fullname: String
    age: Int
  }

  # Post
  type Post {
    id: ID!
    title: String!
    user_id: ID!
    user: User!
    comments: [Comment!]!
  }
  input CreatePostInput {
    title: String!
    user_id: ID!
  }

  input UpdatePostInput {
    title: String
    user_id: ID
  }

  # Comment
  type Comment {
    id: ID!
    text: String!
    post_id: ID!
    user: User!
    post: Post!
  }

  input CreateCommentInput {
    text: String!
    post_id: ID!
    user_id: ID!
  }

  input UpdateCommentInput {
    text: String
    post_id: ID
    user_id: ID
  }

  type DeleteAllOutput{
    count: Int!
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
    # User
    createUser(data: CreateUserInput!): User!
    updateUser(id: ID!, data: UpdateUserInput!): User!
    deleteUser(id: ID!): User!
    deleteAllUsers: DeleteAllOutput!

    # Post
    creatPost(data: CreatePostInput!): Post!
    updatePost(id: ID!, data: UpdatePostInput!): Post!
    deletePost(id: ID!): Post!
    deleteAllPosts: DeleteAllOutput!

    # Comment
    createComment(data: CreateCommentInput!): Comment!
    updateComment(id: ID!, data: UpdateCommentInput!): Comment!
    deleteComment(id: ID!): Comment!
    deleteAllComments: DeleteAllOutput!
  }

  type Subscription{
    userCreated:User!
  }
`;

const uid = function () {
  return Date.now().toString(36) + Math.random().toString(36).substr(2);
};

const resolvers = {
  Subscription:{
    userCreated:{
      subscribe:(_,__,{pubsub})=> pubsub.asyncIterator('userCreated')        
      },
  },
  Mutation: {
    // User
    createUser: (_, args,{pubsub}) => {
      const user = { id: uid(), fullname: args.data.fullname };
      users.push(user);
      pubsub.publish('userCreated',{userCreated: user});
      return user;
    },

    updateUser: (_, { id, data }) => {
      const user_index = users.findIndex((user) => user.id === id);
      if (user_index === -1) {
        throw new Error("User not found.");
      }
      const updated_user = (users[user_index] = {
        ...users[user_index],
        ...data,
      });
      return updated_user;
    },

    deleteUser: (parent, { id }) => {
      const user_index = users.findIndex((user) => user.id === id);
      if (user_index === -1) {  throw new Error("User not found.");  }
      const delete_user = users[user_index];
      users.splice(user_index, 1);
      return delete_user;
    },

    deleteAllUsers:()=>{
      const lenght=users.length;
      users.splice(0,lenght);
      return { count:lenght,}
    },

    // Post
    creatPost: (parent, { data }) => {
      const post = { id: uid(), ...data };
      posts.push(post);
      return post;
    },

    updatePost: (parent, { id, data }) => {
      const post_index = posts.findIndex((post) => post.id === id);
      if (post_index === -1) {
        throw new Error("Post not found");
      }
      const updated_post = (posts[post_index] = {
        ...posts[post_index],
        ...data,
      });
      return updated_post;
    },

    deletePost: (parent, { id }) => {
      const post_index = posts.findIndex((post) => post.id === id);
      if (post_index === -1) {  throw new Error("Post not found.");  }
      const delete_post = posts[post_index];
      posts.splice(post_index, 1);
      return delete_post;
    },

    deleteAllPosts:()=>{
      const lenght=posts.length;
      posts.splice(0,lenght);
      return { count:lenght,}
    },

    // Comment
    createComment: (parent, { data }) => {
      const comment = { id: uid(), ...data };
      comments.push(comment);
      return comment;
    },

    updateComment: (parent, { id, data }) => {
      const comment_index = comments.findIndex((comment) => comment.id === id);
      if (comment_index === -1) {
        throw new Error("Post not found");
      }
      const updated_comment = (comments[comment_index] = {
        ...comments[comment_index],
        ...data,
      });
      return updated_comment;
    },

    deleteComment: (parent, { id }) => {
      const comment_index = comments.findIndex((comment) => comment.id === id);

      if (comment_index === -1) {  throw new Error("Comment not found.");  }

      const delete_comment = comments[comment_index];
      posts.splice(comment_index, 1);

      return delete_comment;
    },

    deleteAllComments:()=>{
      const lenght=comments.length;
      comments.splice(0,lenght);
      return { count:lenght,}
    },

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

const pubsub = new PubSub();
const server = new GraphQLServer({typeDefs,resolvers,context:{pubsub}});

server.start(()=> console.log('Server is running on localhost:4000'));

