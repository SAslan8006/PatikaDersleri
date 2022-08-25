--SELECT title, first_name, last_name FROM book INNER JOIN author ON author.id = book.author_id;
--SELECT * FROM book INNER JOIN author ON author.id = book.author_id;
--SELECT * FROM book INNER JOIN author ON author.id = book.author_id;
SELECT book.title, author.first_name, author.last_name FROM book INNER JOIN author ON author.id = book.author_id;
