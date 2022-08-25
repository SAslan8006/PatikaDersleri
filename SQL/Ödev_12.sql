
1. SELECT COUNT(*) FROM Film WHERE length > (SELECT AVG(length) FROM Film);   

2. SELECT COUNT(*) FROM Film WHERE rental_rate =( SELECT MAX(rental_rate) FROM Film);   
   
3. SELECT title, rental_rate, replacement_cost FROM Film
WHERE rental_rate =(SELECT MIN(rental_rate) FROM Film)
AND replacement_cost =(SELECT MIN(replacement_cost) FROM Film);

4. SELECT customer_id, COUNT(customer_id) FROM payment GROUP BY customer_id ORDER BY COUNT(customer_id) DESC;