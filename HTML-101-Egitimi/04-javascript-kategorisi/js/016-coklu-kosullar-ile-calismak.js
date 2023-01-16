// ********** Coklu Kosullarla Calismak **********

let userName = prompt("Kullanici Adiniz:")
let age = prompt("Yasiniz:")
let info2 = document.querySelector("#info")

if (userName && age >= 18) {
    info2.innerHTML = "ehliyet alabilirsiniz"
} else if (!userName) {
    info2.innerHTML = "Kullanici Adiniz Yok"
} else if ( !(age >= 18) ) {
    info2.innerHTML = "Yas Bilginiz Yok veya 18 Yasindan Kucuksunuz"
}