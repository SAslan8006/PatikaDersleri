
--film tablosunda bulunan rental_rate sütunundaki değerlerin ortalaması nedir?
--SELECT ROUND(AVG(rental_rate),2) FROM film;

--film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile başlar?
--SELECT COUNT(*) FROM film WHERE title LIKE 'C%';

--film tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?
--SELECT MAX(length) FROM film WHERE rental_rate=0.99;

--film tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?
--SELECT COUNT(DISTINCT replacement_cost) FROM film WHERE length>150;