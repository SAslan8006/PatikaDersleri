
const books = [
    { name: "Kitap 1", author: "Yazar 1" },
    { name: "Kitap 2", author: "Yazar 2" },
    { name: "Kitap 3", author: "Yazar 3" },
  ];
  
  const listBooks = () => {
    books.map((book) => {
      console.log(book.name);
    });
  };
  
  const addBook = (newBook, callback) => {
    books.push(newBook);
    callback();
  };
  
  addBook({ name: "Kitap 4", author: "Yazar 4" }, listBooks);
  
  //Çıktımız
  //Kitap 1
  //Kitap 2
  //Kitap 3
  //Kitap 4