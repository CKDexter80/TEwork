USE assessment;
GO

-- Select all columns from posts that are published
SELECT p.id, p.name, p.body, p.published, p.created
FROM posts p
WHERE p.published = 1;

-- Select posted_by and body from comments that have a body and were created after Oct. 15, 2019

SELECT c.posted_by, c.body
FROM comments c
WHERE c.body IS NOT NULL
	AND c.created > '10/15/2019';

-- Select the name and published states from posts ordered by when they were created, earliest first

SELECT p.name, p.published, p.created
FROM posts p
ORDER BY p.created ASC;

-- Select the created date and the count of all the comments created on that date

SELECT c.created, COUNT(*) AS number_of_comments
FROM comments c
GROUP BY c.created
ORDER BY c.created ASC;

-- Select the post name, comment posted_by and comment body for all posts created after Oct. 1st, 2019

SELECT p.name, c.posted_by, c.body
FROM posts p
JOIN comments c ON p.id = c.post_id
WHERE p.created > '10/1/2019';
