// Blog oluşturmaya hazır mısınız? Konsol ekranında postlarımızı sıralayalım, sonrasında yeni bir post oluşturalım ve yeni post ile birlikte postlarımızı tekrar sıralayalım.

const posts = [
    { blog: "Blog 1", description: "Lorem Ipsum Dolor 1" },
    { blog: "Blog 2", description: "Lorem Ipsum Dolor 2" },
    { blog: "Blog 3", description: "Lorem Ipsum Dolor 3" },
    { blog: "Blog 4", description: "Lorem Ipsum Dolor 4" },
    { blog: "Blog 5", description: "Lorem Ipsum Dolor 5" },
  ];
  
  const listPost = () => {
    posts.map((post) => {
      console.log(post);
    });
  };
  
  const addPost = (newPost, callback) => {
    posts.push(newPost);
    callback();
  };
  
  addPost({ blog: "Blog  6", description: "Lorem Ipsum Dolor 6" }, listPost);