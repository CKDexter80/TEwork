-- 4. Add a "Sports" genre to the genre table. Add the movie "Coach Carter" to the newly created genre. (1 row each)

INSERT INTO genre (genre_name)
VALUES ('Sports');

INSERT INTO movie_genre (movie_id, genre_id)
VALUES (
	(SELECT m.movie_id FROM movie m WHERE m.title = 'Coach Carter'),
	(SELECT g.genre_id FROM genre g WHERE g.genre_name = 'Sports')
	);