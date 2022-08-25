--Ödev 9
--Q1:
SELECT city, country FROM city
INNER JOIN country ON city.country_id=country.country_id;

--Q2:
SELECT payment_id, first_name, last_name FROM customer
INNER JOIN payment ON customer.customer_id = payment.customer_id;

--Q3:
SELECT rental_id, first_name, last_name FROM customer
INNER JOIN rental ON customer.customer_id = rental.customer_id;