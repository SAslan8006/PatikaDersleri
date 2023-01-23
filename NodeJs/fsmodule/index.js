import fs from "node:fs";

//Dosya Okumak
fs.readFile("password.txt", "utf8", (err, data) => {
  if (err) throw err;
  console.log(data);
  console.log("Dosya okundu.");
});

//Dosya Yazmak
fs.writeFile('message.txt', 'Hello Node.js', 'utf8', (err) => {
  if (err) throw err;
  console.log("Dosya yazıldı.");
});

//Dosya Yazmak
fs.writeFile('example.json', '{"name": "Arin", "age": 6}', 'utf8', (err) => {
  if (err) console.log(err);
  console.log("Json Dosya yazıldı.");

});

//Dosyaya Veri Eklemek
fs.appendFile('message.txt', '\nYENI TEXT', 'utf8', (err) => {
  if (err) console.log(err);
  console.log("Message dosyasına yeni veri eklendi.");

});

//Dosyaya Silmek
fs.unlink('example.json', (err) => {
  if (err) console.log(err);
  console.log("Json silindi.");

});

//Klasör Oluşturmak
fs.mkdir('uploads/img', { recursive: true }, (err) => {
  if (err) console.log(err);
});

//Klasör Silmek
fs.rmdir('uploads', { recursive: true }, (err) => {
  if (err) console.log(err);
})