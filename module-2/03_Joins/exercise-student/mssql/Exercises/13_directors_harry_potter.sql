-- 13. The directors of the movies in the "Harry Potter Collection" (4 rows)

SELECT DISTINCT p.person_name
FROM movie m
JOIN person p ON m.director_id = p.person_id
JOIN collection c ON m.collection_id = c.collection_id
WHERE c.collection_name = 'Harry Potter Collection';