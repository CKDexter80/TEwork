-- 8. The genres of movies that Robert De Niro has appeared in that were released in 2010 or later (6 rows)


SELECT DISTINCT g.genre_name
FROM movie m
JOIN movie_genre mg ON m.movie_id = mg.movie_id
JOIN genre g ON mg.genre_id = g.genre_id
JOIN movie_actor ma ON m.movie_id = ma.movie_id
JOIN person p ON p.person_id = ma.actor_id
WHERE p.person_name = 'Robert De Niro'
	AND	m.release_date >= '2010-01-01';