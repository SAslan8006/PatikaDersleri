// array filter kullanimi
// https://developer.mozilla.org/tr/docs/Web/JavaScript/Reference/Global_Objects/Array/filter

// 5 harften fazla olanlar (6) ??
const PRODUCTS = ["Mic", "Cable", "Speaker", "Desktop PC", "Server", "Mouse", "Keyboard"]

const NEW_PRODUCTS = PRODUCTS.filter(item => item.length > 5)
console.log(NEW_PRODUCTS)


// aktif kullanicilar ??
const USERS = [
  {fullName: "Ayse Sumer",yas:30, isActive: false},
  {fullName: "Ahmet Urgan",yas:23,isActive: true},
  {fullName: "Asya Basar",yas:31,isActive: true},
  {fullName: "Aksel Durmaz",yas:18,isActive: false},
]

// const ACTIVE_USERS = USERS.filter(user => user.isActive === true)
const ACTIVE_USERS = USERS.filter(user => !user.isActive )
console.log(ACTIVE_USERS)
const usserAd=USERS.filter(user=>user.yas<=23 && user.isActive)
console.log(usserAd)
