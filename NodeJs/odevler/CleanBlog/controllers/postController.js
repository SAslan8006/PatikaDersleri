const Post = require("../modals/Post");

exports.getAllPosts = async (req, res) => {
  const posts = await Post.find({}).sort("-dateCreated");
  res.render("index", { posts });
};

exports.getPost = async (req, res) => {
  const post = await Post.findById(req.params.id);
  res.render("post-detail", { post });
};

exports.createPost = async (req, res) => {
  await Post.create(req.body);
  res.redirect("/");
};

exports.updatePost = async (req, res) => {
  const post = await Post.findById(req.params.id);
  post.title = req.body.title;
  post.detail = req.body.detail;
  await post.save();
  res.redirect(`/post/${post._id}`);
};

exports.deletePost = async (req, res) => {
  await Post.findByIdAndDelete(req.params.id);
  res.redirect("/");
};
