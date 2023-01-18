let listDOM = document.querySelector('#list')   //Eklenecek liste seçimi
let LocalTask = {id:"", task:"" , check: false} //LocalStorage bilgilerini tutacak object
let ArrayTask = []                              //LocalStorage için array
let i=0;                                        //id ataması için değişken.(bu sayede liste elemanlarına daha kolay erişebileceğiz)

//LocalStorage işlemleri
if(localStorage.getItem('load'))    //LocalStorage varsa gir
{   
    ArrayTask = JSON.parse(localStorage.getItem('load')) //LocalStorage çağır
    ArrayTask.forEach(function (element)                 //LocalStorage 'deki bilgiyi aktarmak için fonksiyon
    {
        i++;
        element.id = `id${i}`;                           //LocalStorage yeni id ataması
        localStorage.setItem('load', JSON.stringify(ArrayTask))

        let liDOM = document.createElement(`li`)        //liste elemanını oluşturma
        liDOM.setAttribute('id',`id${i}`)               //liste elemanına "id" atama
        liDOM.innerHTML =                               //liste elemanına Eklencek bilgiyi atama 
        `
        ${element.task} 
        <button
        class="close" 
        style="width: 50px; height: 50px; text-align: center;"
        onclick="RemoveFunc(${i})"
        >x
        </button>
        `
/*      (${element.task} liste elemanı bilgisi 
        </button>        silme butonu "x" 
        RemoveFunc(${i}) silme fonksiyonu       */

        listDOM.append(liDOM)    //liste elemanını listenin sonuna ekleme
        if(ArrayTask[i-1].check) //liste elemanı "check" edilmiş ise işaretleme
        {
            let changeLi = document.querySelector(`#id${i}`) //liste elamanının ataması
            changeLi.classList.add("checked")                //liste elamanının "checked" classını ekle
        }
    });
}


// Ekle butonunu <span> tipinden <button> tipine çevirme. (bu şekilde listeye "enter" ile ekleme yapılabilcek)
let elem = document.querySelector('#liveToastBtn')
elem.outerHTML = `<button type="submit" onclick="newElement()" id="liveToastBtn" class="button" style ="border-width: 0px">${elem.innerHTML}</button>`;


//Kutuya yazılan bilgiyi alma
let userTaskDOM = document.querySelector('#userTask')
userTaskDOM.addEventListener('submit', formHandler)

//Kutudaki bilgi (input) için işlemler
function formHandler(event) {
    event.preventDefault()                          //Sayfa yenilenmesini engeleme
    const TASK = document.querySelector("#task")    //Kutudaki bilginin atanması
    
    if (TASK.value.trim() == ""){   //"input" değeri boş ise "toast" bildirimi ile 
        $(".error").toast("show");  //"Listeye boş ekleme yapamazsınız!" bildirimini göster
    } 
    else{
        addItem(TASK.value)          //Bilgi ekleme fonksiyonunu çalıştır
        TASK.value = ""              //Gonderdikten sonra "input" sıfırlama 
        $(".success").toast("show"); //"Bilgi eklendi" bildirimini göster
    }
}


//Bilgi ekleme fonksiyonu
const addItem = (task) => 
{ 
    i++;

    LocalTask.task = task;    //"object" bilgiyi gönder
    LocalTask.id = `id${i}`;  //"object" id gönder
    ArrayTask.push(LocalTask) //LocalStorage için "object" teki bilgileri gönder
    localStorage.setItem('load', JSON.stringify(ArrayTask))
    ArrayTask = JSON.parse( localStorage.getItem('load'))

    let liDOM = document.createElement(`li`)        //liste elemanını oluşturma
    liDOM.setAttribute('id',`id${i}`)               //liste elemanına "id" atama
    liDOM.innerHTML =                               //liste elemanına Eklencek bilgiyi atama 
    `
    ${task} 
    <button 
    class="close" 
    style="width: 50px; height: 50px; text-align: center;"
    onclick="RemoveFunc(${i})"
    >x
    </button>
    `
    listDOM.append(liDOM)       //liste elemanını listenin sonuna ekleme
}

//Silme fonksiyonu
function RemoveFunc(j) {                                        //"j" id numarası
    const element = document.querySelector(`#id${j}`);          //silinecek liste elemanını için atama

    let index = ArrayTask.findIndex(function (Atask) {          //silinecek liste elemnını LocalStorage içindeki "index"ine ulaşmak
        return JSON.stringify(Atask).indexOf(`id${j}`) >= 0
    });
        ArrayTask.splice(index, 1)                              //silinecek liste elemanını LocalStorage içinden silme
        localStorage.setItem('load', JSON.stringify(ArrayTask)) //sildikten sonra tekrar set etmemiz lazım
        ArrayTask = JSON.parse( localStorage.getItem('load') )
        element.remove();                                       //liste elemanını silme
}

//Checked işlemi
document.addEventListener('click', (element) =>                 //tıklanan liste elemanına ulaşma
{
    if(element.target.matches('li'))                            //liste elemanı mı diye kontrol
    {
        let elementId = element.target.id;                      //liste elemanının "id" sine ulaşma
        let index = ArrayTask.findIndex(function (Atask) {      //liste elemanının LocalStorage içindeki "index"ine ulaşmak
            return JSON.stringify(Atask).indexOf(`${elementId}`) >= 0
        });
        ArrayTask[index].check = !(ArrayTask[index].check)      //LocalStorage içindeki "check" bilgisini değiştirme
        localStorage.setItem('load', JSON.stringify(ArrayTask)) //değiştirdikten sonra tekrar set etmemiz lazım
        ArrayTask = JSON.parse( localStorage.getItem('load') )
        
        let changeLi = document.querySelector(`#${elementId}`) //liste elamanının ataması
        changeLi.classList.toggle("checked")                   //liste elamanına "checked" class bilgisi varsa kaldır yoksa ekle
    }
});
