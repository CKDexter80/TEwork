-- 3. Did you know Eric Stoltz was originally cast as Marty McFly in "Back to the Future"? Add Eric Stoltz to the list of actors for "Back to the Future" (1 row)

INSERT INTO movie_actor (movie_id, actor_id)
VALUES (
	(SELECT m.movie_id FROM movie m WHERE title = 'Back to the Future'),
	(SELECT p.person_id FROM person p WHERE p.person_name = 'Eric Stoltz')
	);