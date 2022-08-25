--------------------1------------------
SELECT  city, country FROM city LEFT JOIN country ON city.country_id = country.country_id;

--------------------2------------------
SELECT customer.first_name ,customer.last_name , payment.payment_id FROM payment  
RIGHT JOIN customer ON  customer.customer_id = payment.customer_id;

--------------------3------------------
Select rental_id,first_name,last_name from  customer 
FULL JOIN rental ON customer.customer_id=rental.customer_id
ORDER BY  rental_id;