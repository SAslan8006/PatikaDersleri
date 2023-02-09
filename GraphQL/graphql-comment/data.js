const users = [
  { id: "1", fullname: "Yusuf Soyhan",age:29 },
  { id: "2", fullname: "Tahsin Demirci" , age:24},
];

const posts = [
  { id: "1", title: "Yusuf gönderisi", user_id: "1" },
  { id: "2", title: "Tahsin gönderisi", user_id: "1" },
  { id: "3", title: "Tahsin gönderisi", user_id: "2" },
];

const comments = [
  { id: "1", text: "Lorem Ipsum", post_id: "1", user_id: "1" },
  { id: "2", text: "foo bar", post_id: "1", user_id: "2" },
  { id: "3", text: "foo var baz", post_id: "2", user_id: "1" },
  { id: "4", text: "Lorem Ipsum baz", post_id: "2", user_id: "3" },
];

module.exports = {
  users,
  posts,
  comments,
};
