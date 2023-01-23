function getData(data) {
    return new Promise((resolve, reject) => { // promise dönüyoruz.
      console.log("Veriler alınmaya çalışılıyor..");
  
      if (data) {
        resolve("Verilen alındı"); 
      } else {
        reject("Veriler alınamadı");
      }
    });
  }
  
  function cleanData(receivedData) { // promise dönüyoruz.
    return new Promise((resolve, reject) => {
      console.log("Veriler düzenleniyor..");
  
      if (receivedData) {
        resolve("Verilen düzenlendi"); 
      } else {
        reject("Veriler düzenlenemedi");
      }
    });
  }
  
  async function processData() {
    try {// Hata yakalamak için try - bloğu kullanılıyor.catch 
      const receivedData = await getData(true); // await verilerin tamamıyla alındığından emin oluyor
      console.log(receivedData);
      const cleanedData = await cleanData(false);
      console.log(cleanedData); // await verilerin temizlendiğinden emin oluyor
    } catch (error) {
      console.log(error);
    }
  }
  
  processData();
  
  //ÇIKTI
  //Veriler alınmaya çalışılıyor..
  //Verilen alındı
  //Veriler düzenleniyor..
  //Veriler düzenlenemedi

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
  
  const addBook = (newBook) => {
    const promise1 = new Promise((resolve, reject) => {
      books.push(newBook);
      resolve(books);
      //reject('BIR HATA OLUSTU');
    });
  
    return promise1;
  };
  
  async function showBooks() {
    try {
      await addBook({ name: "Kitap 4", author: "Yazar 4" });
      listBooks();
    } catch (error) {
      console.log(error);
    }
  }
  
  showBooks();