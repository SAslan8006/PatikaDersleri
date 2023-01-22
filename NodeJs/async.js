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