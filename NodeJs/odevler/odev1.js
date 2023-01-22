// Hepimizin Matematik derslerinden bildiği üzere Dairenin Alanı = π x r2 şeklinde hesaplanır. 
// Node.JS Javascript çalışma ortamında yarıçap değerini konsoldan parametre olarak girerek alanı bulmaya çalışacağız. 
// Konsol çıktısı: Yarıçapı (Yarıçap) olan dairenin alanı: (Alan) şeklinde olmalıdır.

const argument = process.argv.slice(2);

function alanBul(r) {
  let alan = Math.PI.toFixed(2) * r ** 2;
  console.log(`Yarıçapı ${r} olan dairenin alanı: ${alan}`);
}

alanBul(argument[0]);