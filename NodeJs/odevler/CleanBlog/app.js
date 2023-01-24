const express = require("express");
const mongoose = require("mongoose");
const path = require("path");
const ejs = require("ejs");
const methodOverride = require("method-override");

const app = express();

const Post = require("./modals/Post");
const {
  getAllPosts,
  getPost,
  createPost,
  updatePost,
  deletePost
} = require("./controllers/postController");
const {
  aboutPage,
  homePage,
  addPage,
  editPage
} = require("./controllers/pageController");

// TEMPLATE ENGINE
app.set("view engine", "ejs");

// MIDDLEWARE
app.use(express.static("public"));
app.use(express.urlencoded({ extended: true }));
app.use(express.json());
app.use(methodOverride("_method", { methods: ["POST", "GET"] }));

// ROUTES
app.get("/", getAllPosts); // home page
app.get("/post/:id", getPost); // post detail page
app.post("/add", createPost); // add new post
app.put("/post/:id", updatePost); // update post
app.delete("/post/:id", deletePost); // delete post
app.get("/home", homePage); // home page
app.get("/about", aboutPage); // about page
app.get("/add", addPage); // add post page
app.get("/post/edit/:id", editPage); // edit post page

mongoose.set("strictQuery", false);
mongoose.connect(
  "mongodb://127.0.0.1/clean-blog-db",
  {
    useNewUrlParser: true,
    useUnifiedTopology: true
  },
  err => {
    if (err) throw err;
    console.log("Connected to MongoDB");
    const PORT = 3001;
    app.listen(PORT, () => {
      console.log(`Server is running on port ${PORT}`);
    });
  }
);
