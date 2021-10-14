-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were released in 1985 (20 rows)

SELECT DISTINCT p.person_name, p.birthday
FROM person p
JOIN movie_actor ma ON p.person_id = ma.actor_id
JOIN movie m ON ma.movie_id = m.movie_id
WHERE m.release_date LIKE '1985-%'
	AND p.birthday BETWEEN '1950-01-01'
		AND '1959-12-31';