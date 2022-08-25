--SELECT MAX(length) FROM film WHERE rental_rate = 0.99;
--SELECT MAX(length) FROM film WHERE rental_rate = 2.99;
--SELECT MAX(length) FROM film WHERE rental_rate = 4.99;

--SELECT rental_rate, MAX(length) FROM film GROUP BY rental_rate;
--SELECT rental_rate, Count(*) FROM film GROUP BY rental_rate;
--SELECT rating, Count(*) FROM film GROUP BY rating;
SELECT replacement_cost, MIN(length) FROM film GROUP BY replacement_cost;
