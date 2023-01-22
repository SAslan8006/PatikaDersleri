// Daire alan : circleArea ve daire çevre : circleCircumference fonksiyonları içeren ve consola sonuçları yazdıran circle.js dosyası oluşturunuz.
// Module.exports yöntemi ile fonksiyonları oluştururken export ediniz.
// require ve object destructing kullanarak index.js dosyasında yarıçap (r) 5 olacak şekilde ekran çıktısını alınız.

const { circleArea, circleCircumFerence } = require("./circle");

console.log(`Dairenin Alanı: ${circleArea(4)} `);
console.log(`Dairenin Çevresi: ${circleCircumFerence(4)} `);