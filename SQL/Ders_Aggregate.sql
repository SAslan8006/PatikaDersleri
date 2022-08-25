--SELECT ROUND(AVG(length),2),ROUND(sum(length),2) FROM film;
--SELECT SUM(length) FROM film;
--SELECT MAX(length) FROM film;
--SELECT MIN(length) FROM film;
SELECT Max(length) FROM film WHERE rental_rate IN(2.99, 0.99);
--SELECT MIN(length) FROM film WHERE rental_rate=4.99;