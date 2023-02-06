const authors = [
    {
      id: '1',
      name: 'Albert',
      surname: 'Camus',
      age: '50',
    },
    {
      id: '2',
      name: 'George',
      surname: 'Orwell',
      age: '45'
    },
  ];
  
  const books = [
    {
      id: '1',
      title: 'Yabancı',
      author_id: '1',
      score: 7.3,
      isPublished: true,
    },
    {
      id: '2',
      title: 'Albert C. Kitap',
      author_id: '1',
      score: 2.4,
      isPublished: true,
    },
    {
      id: '3',
      title: 'Hayvan çiftiliği',
      author_id: '2',
      score: 7.3,
      isPublished: true,
    },
  ];
  
  
  module.exports = { authors, books }