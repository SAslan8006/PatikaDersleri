--ÖDEV 7
--Film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.
-- SELECT rating, COUNT(*) FROM film GROUP BY rating ORDER BY COUNT(*);

--Film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.
-- SELECT replacement_cost, COUNT(*) FROM film GROUP BY replacement_cost HAVING COUNT(*) > 50 ORDER BY COUNT(*); 

--Customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir?
--SELECT store_id, COUNT(*) FROM customer GROUP BY store_id ORDER BY COUNT(*);

--City tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.
-- SELECT country_id, COUNT(*) FROM city GROUP BY country_id ORDER BY COUNT(*) DESC LIMIT 1;