-- INNER JOIN

-- Write a query to retrieve the name and state abbreviation for the 2 cities named "Columbus" in the database

SELECT city_name, state_abbreviation
FROM city
WHERE city.city_name = 'Columbus';
-- Modify the previous query to retrieve the names of the states (rather than their abbreviations).

SELECT city.city_name, city.state_abbreviation, state.state_name
FROM city
JOIN state ON state.state_abbreviation = city.state_abbreviation
WHERE city.city_name = 'Columbus';

--same statement as above only using an alias for table names
SELECT c.city_name, c.state_abbreviation, s.state_name
FROM city c
JOIN state s ON s.state_abbreviation = c.state_abbreviation
WHERE c.city_name = 'Columbus';

-- Write a query to retrieve the names of all the national parks with their state abbreviations.
-- (Some parks will appear more than once in the results, because they cross state boundaries.)

SELECT park_name, park_state.state_abbreviation
FROM park
JOIN park_state ON  park_state.park_id = park.park_id;

-- The park_state table is an associative table that can be used to connect the park and state tables.
-- Modify the previous query to retrieve the names of the states rather than their abbreviations.

SELECT park_name, state.state_name
FROM park
JOIN park_state ON  park_state.park_id = park.park_id
JOIN state ON park_state.state_abbreviation = state.state_abbreviation;

-- Modify the previous query to include the name of the state's capital city.

--SELECT * ----shows all columns
SELECT park_name, state.state_name, city.city_name
FROM park
JOIN park_state ON  park_state.park_id = park.park_id
JOIN state ON park_state.state_abbreviation = state.state_abbreviation
JOIN city ON state.capital = city_id

-- Modify the previous query to include the area of each park.

SELECT park_name, park.area, state.state_name, city.city_name
FROM park
JOIN park_state ON park_state.park_id = park.park_id
JOIN state ON park_state.state_abbreviation = state.state_abbreviation
JOIN city ON state.capital = city_id

--same as above but using more beautiful and ELEGANT sql code 
--that looks way better
SELECT park_name, p.area, s.state_name, city.city_name
FROM park p
JOIN park_state ps ON ps.park_id = p.park_id
JOIN state s ON ps.state_abbreviation = s.state_abbreviation
JOIN city ON s.capital = city_id

-- Write a query to retrieve the names and populations of all the cities in the Midwest census region.

--SELECT c.city_name
SELECT city_name, c.population
FROM city c
JOIN state s ON s.state_abbreviation = c.state_abbreviation
WHERE census_region = 'Midwest';

-- Write a query to retrieve the number of cities in the city table for each state in the Midwest census region.

SELECT s.state_name, COUNT(c.city_name) AS number_of_cities
FROM city c
JOIN state s ON s.state_abbreviation = c.state_abbreviation
WHERE s.census_region = 'Midwest'
GROUP BY s.state_name

-- Modify the previous query to sort the results by the number of cities in descending order.

SELECT s.state_name, COUNT(c.city_name) AS number_of_cities
FROM city c
JOIN state s ON s.state_abbreviation = c.state_abbreviation
WHERE s.census_region = 'Midwest'
GROUP BY s.state_name
ORDER BY number_of_cities DESC


-- LEFT JOIN

-- Write a query to retrieve the state name and the earliest date a park was established in 
--that state (or territory) for every record in the state table that has park records associated with it.

SELECT s.state_name, MIN(p.date_established) AS earliest_park_established
FROM state s
INNER JOIN park_state ps ON s.state_abbreviation = ps.state_abbreviation
INNER JOIN park p ON ps.park_id = p.park_id
GROUP BY s.state_name

-- Modify the previous query so the results include entries for all the records in the state table, 
--even if they have no park records associated with them.

SELECT s.state_name, MIN(p.date_established) AS earliest_park_established
FROM state s
LEFT JOIN park_state ps ON s.state_abbreviation = ps.state_abbreviation
LEFT JOIN park p ON ps.park_id = p.park_id
GROUP BY s.state_name


-- UNION

-- Write a query to retrieve all the place names in the city and state tables that begin with "W" sorted alphabetically. 
--(Washington is the name of a city and a state--how many times does it appear in the results?)
SELECT city_name
FROM city
UNION --ALL includes dupes
SELECT state_name
FROM state;

-- Modify the previous query to include a column that indicates whether the place is a city or state.



-- MovieDB
-- After running the script to set up the MovieDB database, make sure it is selected in SSMS and confirm it is working correctly by writing queries to retrieve...

-- The names of all the movie genres


-- The titles of all the Comedy movies

