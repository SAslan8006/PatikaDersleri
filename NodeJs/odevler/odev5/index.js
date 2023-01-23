// Kendi bilgisayarımızda aşağıdaki özellikleri kullanarak sunucumuzu yazalım.

// createServer metodunu kullanacağız.
// index, hakkimda ve iletisim sayfaları oluşturalım.
// Sayfalara içerik olarak xxx sayfasına hoşgeldiniz şeklinde başlıkları yazdıralım.
// port numarası olarak 5000'i kullanalım.

const http = require("http");

const server = http.createServer((req, res) => {
  const url = req.url;

  if (url === "/") {
    res.writeHead(200, { "Content-Type": "text/html" });
    res.write("<h2>INDEX SAYFASI</h2>");
  } else if (url === "/hakkimda") {
    res.writeHead(200, { "Content-Type": "text/html" });
    res.write("<h2>HAKKIMDA SAYFASI</h2>");
  } else if (url === "/iletisim") {
    res.writeHead(200, { "Content-Type": "text/html" });
    res.write("<h2>ILETISIM SAYFASI</h2>");
  } else {
    res.writeHead(404, { "Content-Type": "text/html" });
    res.write("<h2>404 SAYFA BULUNAMADI</h2>");
  }

  console.log("Bir istek gönderildi.");
  res.end();
});

const port = 5000;
server.listen(port, () => {
  console.log(`Sunucu Port ${port} de Başlatıldı.`);
});