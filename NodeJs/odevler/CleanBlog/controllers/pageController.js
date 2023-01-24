exports.aboutPage = (req, res) => {
  res.render("about");
};

exports.homePage = (req, res) => {
  res.render("index");
};

exports.addPage = (req, res) => {
  res.render("add_post");
};

exports.editPage = async (req, res) => {
  const post = await Post.findById(req.params.id);
  res.render("edit", { post });
};
