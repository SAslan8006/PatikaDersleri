--CREATE TABLE my_apps ( id INT,	name VARCHAR(50), price VARCHAR(50));
--INSERT INTO my_apps (id, name, price) values (1, 'Ronstring', '$0.96');
--INSERT INTO my_apps (id, name, price) values (2, 'Duobam', '$3.44');
--INSERT INTO my_apps (id, name, price) values (3, 'Tresom', '$2.21');
--INSERT INTO my_apps (id, name, price) values (4, 'Redhold', '$2.52');
--INSERT INTO my_apps (id, name, price) values (5, 'Y-find', '$9.14');
--UPDATE author SET first_name = 'Yakup',	email = 'yasiin@gmail.com' WHERE id = 3;
--DELETE FROM my_apps
--WHERE name = 'Tresom';
--select * from author;
--UPDATE author SET last_name = 'Kasım',	email = 'kasinyasin@gmail.com' WHERE id = 5 RETURNING *;

DELETE FROM author WHERE id = 2 RETURNING *;



