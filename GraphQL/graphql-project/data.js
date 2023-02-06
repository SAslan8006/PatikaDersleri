const authors = [
  {
    id: "1",
    name: "Albert",
    surname: "Camus",
    age: 50,
    books: [
      { id: "1", title: "Test Title", score: 9, isPublished: false },
      { id: "2", title: "Test Title", score: 9, isPublished: false },
    ],
  },
  {
    id: "2",
    name: "Stephen",
    surname: "Hawkins",
    age: 60,
    books: [
      { id: "1", title: "Test Title", score: 9, isPublished: false },
      { id: "2", title: "Test Title", score: 9, isPublished: false },
    ],
  },
];

const books = [
  {
    id: "1",
    title: "The Awakening",
    author: authors[0],
    score: 5.8,
    isPublished: true,
  },
  {
    id: "2",
    title: "Gazap Üzümleri",
    author: authors[1],
    score: 5.8,
    isPublished: true,
  },
];

module.exports = { authors, books };
