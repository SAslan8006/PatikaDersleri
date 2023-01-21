# Star Wars API (SWAPI)
SWAPI, Star Wars ekosistemine ait olan filmlerin, kahramanların, gezegenlerin vb bilgilerin sunulduğu ücretsiz bir API ortamıdır. İlk pratik çalışma olarak SWAPI seçmekteki yaklaşımın:  

## API istekleri yapma alışkanlığı kazanmak
Hazır bir API kullanımı ve ilgili dökümantasyonu incelemek   
Resource, EndPoint, Status Code gibi teorik olarak konuştuğumuz konuları pratik yapmak  
Postman kullanım alışkanlığı kazanmak  
## Yapılan İstekler
GET POPULAR MOVIES - GET : https://api.themoviedb.org/3/movie/popular  
GET A MOVIE DETAIL - GET : https://api.themoviedb.org/3/movie/:movie_id  
SEARCH FILM - GET : https://swapi.dev/api/films/?search="value"   
   
Daha Fazlası İçin  
SWAPI - Dökümantasyon - https://swapi.dev/documentation  

# The Movie Database API (TMDBAPI)
TMDB API, IMDB benzeri bir film ve TV programları portalidir. TMDB API pratiğimizde aşağıdaki kavramlar üzerine konuşacağız:

## API key
Query parametresi, Path değişkenleri, Session, Token  
## POST, DELETE HTTP metotları
## Yapılan İstekler
GET ALL FILMS - GET : https://swapi.dev/api/films/  
GET A FILM DETAIL - GET : https://swapi.dev/api/films/:film_id   
CREATE A REQUEST TOKEN - GET : https://api.themoviedb.org/3/authentication/token/new  
CREATE A SESSION ID - POST : https://api.themoviedb.org/3/authentication/session/new  
RATE A MOVIE - POST : https://api.themoviedb.org/3/movie/:movie_id/rating?session_id={{session_id}}  
DELETE A MOVIE RATE - DELETE : https://api.themoviedb.org/3/movie/:movie_id/rating?session_id={{session_id}}  

## Daha Fazlası İçin  
TMDB - Dökümantasyon https://developers.themoviedb.org/3/getting-started  


# Fake API Kullanımı (JSON-SERVER)
Bu pratiğimizde bir Fake (göstermelik) REST API oluşturacağız. Fake REST API oluşturmanın avantajları:  
  
Frontend (Ön yüz) tarafı hazır olan bir uygulamayı test etmek isteyebiliriz.  
Yapmayı düşündüğümüz bir Backend (Arka yüz) çalışması için bir prototip oluşturmak isteyebiliriz.  
Postman gibi bir API platformunda farklı HTTP metotlarına ait istekler gerçekleştirmek isteyebiliriz.  
FAKE REST API oluşturmak için json-server npm paketinden faydalanacağız, bunun için bilgisayarımızda JavaScript çalışma Node.js ( https://nodejs.org/en/) uygulamasının yüklü olması gerekmektedir. Başlangıç olarak   

npm init  
komutu ile package.json dosyası oluşturacağız.   

npm i json-server  
komutu ile json-server paketini indiriyoruz.  

API için kullanacağımız örnek employees.json dosyası : https://github.com/Kodluyoruz/taskforce/blob/main/rest/FakeAPI/files/employees.json .   Bu dosyayı oluşturacağımız api klasörünün içerisinde yerleştiriyoruz.  

Projemizde bulunan package.json dosyası içerisindeki script bölümünü aşağıdaki şekilde güncelliyoruz.    

  "scripts": {  
    "start:server": "json-server --watch api/employees.json"    
  },  
Bu sayede aşağıdaki komut ile FAKE API çalışmaya başlayacak.  

npm run start:server  
##  Örnek İstekler 
GET ALL EMPLOYEES - GET : http://localhost:3000/employees  
GET AN EMPLOYEE DETAILS - GET : http://localhost:3000/employees/:employee_id  
EMPLOYEES - ROLES RELATION - GET : http://localhost:3000/employees?_expand=role  
ADD AN EMPLOYEE - POST : http://localhost:3000/employees  
UPDATE AN EMPLOYEE - PATCH(PUT) : http://localhost:3000/employees/:employee_id  
DELETE AN EMPLOYEE - DELETE : http://localhost:3000/employees/:employee_id  

Daha Fazlası İçin  
JSON-SERVER GITHUB https://github.com/typicode/json-server  
Node.js Dokümantasyon https://nodejs.org/en/docs/   


# cURL Nedir?
URL üzerinden veri transferi yapmamızı sağlayan bir komut satırı aracıdır. REST API çerçeverinde sorgu adreslerine yapılan isteklerde sıklıkla kullanılır. HTTP, HTTPS, FTP, FTPS, GOPHER, GOPHERS, IMAP, IMAPS vs.. bir çok protokolü desteklemektedir.

##  cURL indir
https://curl.se/download.html  
https://git-scm.com/downloads (Git Bash kullanımı için)  
## cURL komut sseçenekleri  
-i (--include): Çıktı içerisinde HTTP başlıklarını da gösterir.  
-I (--head): Yalnızca HTTP başlıklarını görmek için kullanılır.  
-o (--output) <file> : Çıktıyı bir dosyaya yazdırmak için kullanılır.  
-v (--verbose): Daha fazla detay.  
Çalışmada bulunan cURL komutları  
## GET A FILM DTEAIL (SWAPI)  
curl https://swapi.dev/api/films/1/  
## GET POPULAR MOVIES (TMDBAPI)
curl https://api.themoviedb.org/3/movie/popular?api_key=your_api_key  
GET POPULAR MOVIES (TMDBAPI) -d seçeneği ile   
curl -X GET -G -d api_key=your_api_key https://api.themoviedb.org/3/movie/popular  
GET A MOVIE DETAIL (TMDBAPI) -d seçeneği ile  
curl -X GET -G -d api_key=your_api_key https://api.themoviedb.org/3/movie/:movie_id  
## GET ALL EMPLOYEES (Fake API)
curl http://localhost:3000/employees  
## GET AN EMPLOYEE DETAIL (Fake API)
curl http://localhost:3000/employees/:employee_id  
## POST AN EMPLOYEE (Fake API)
curl -X POST -H "Content-Type: application/json" -d '{ "first_name": "Ricardo", "last_name": "Quaresma", "email": "ricardo@test.tr", "gender": "Male", "roleId": 3 }' http://localhost:3000/employees  
## DELETE AN EMPLOYEE (Fake API)
curl -X DELETE http://localhost:3000/employees/:employee_id  
## UPDATE AN EMPLOYEE (Fake API) - PATCH
curl -X PATCH -H "Content-Type: application/json" -d '{ "first_name": "Ricardo", "last_name": "Quaresma"}' http://localhost:3000/employees/:employee_id  
##  UPDATE AN EMPLOYEE (Fake API) - PUT
curl -X PUT -H "Content-Type: application/json" -d '{ "first_name": "Ricardo", "last_name": "Quaresma"}' http://localhost:3000/employees/:employee_id   
   
## Daha Fazlası İçin
cURL - Dökümantasyon https://curl.se/docs/  