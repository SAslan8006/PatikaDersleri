function writeName(name, callback) { // writeName fonksiyonu argüman olrak bir callback fonksiyonu alıyor
    callback(name); 
  }
  
  function writer(word) { // writer fonksiyonu 
    console.log(word);
  }
  
  writeName("Ahmet", writer); // writeName fonksiyonu çalıştırılırken writer fonksiyonu callback işlevi görüyor