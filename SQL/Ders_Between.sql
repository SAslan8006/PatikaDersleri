--SELECT * FROM film WHERE length BETWEEN 100 AND 140;
--SELECT * FROM film WHERE length = 30 OR length = 60 OR length = 90 OR length = 120;
--SELECT * FROM film WHERE length IN (30,60,90,120);
--SELECT rental_rate,replacement_cost FROM film WHERE (rental_rate between 2 and 4) and (replacement_cost BETWEEN 10 and 20);
--SELECT * FROM film WHERE length IN (40,60,50);
SELECT * FROM film WHERE length IN (40,60,50);