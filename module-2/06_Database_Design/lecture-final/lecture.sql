USE [master];
GO

IF DB_ID('ArtGallery') IS NOT NULL
BEGIN
	ALTER DATABASE [ArtGallery] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE [ArtGallery];
END

CREATE DATABASE [ArtGallery];
GO

USE [ArtGallery];
GO

CREATE TABLE customer 
(
	customerId	INT				IDENTITY(1,1), --not indicating PK, surrogate pk
	name		VARCHAR(100)	NOT NULL,
	address		VARCHAR(100)	NOT NULL,
	phone		VARCHAR(20)		NULL,

	CONSTRAINT pk_customer_id PRIMARY KEY (customerId)
);

CREATE TABLE artist
(
	artistId		INT				IDENTITY(1,1),
	firstName		VARCHAR(3000)	NOT NULL,
	lastName		VARCHAR(3000)	NOT NULL,

	CONSTRAINT pk_artist_id PRIMARY KEY (artistId)
);


CREATE TABLE art
(
	artId		INT				IDENTITY(1,1),
	title		VARCHAR(250)	NOT NULL,
	artistID	INT				NOT NULL,

	CONSTRAINT pk_art_id PRIMARY KEY (artId),
	CONSTRAINT fk_art_artist FOREIGN KEY (artistID) REFERENCES artist(artistId)

);

CREATE TABLE customer_purchases
(
	customerId		INT			NOT NULL,
	artId			INT			NOT NULL,
	purchaseDate	DATETIME	NOT NULL,
	price			MONEY		NOT NULL,

	CONSTRAINT pk_customer_purchases PRIMARY KEY (customerId, artId, purchaseDate), -- associative tables also use composite PK
	CONSTRAINT fk_customer_purchase FOREIGN KEY (customerId) REFERENCES customer (customerId),
	CONSTRAINT fk_art_purchase FOREIGN KEY (artId) REFERENCES art (artId)
);

--ALTER TABLE [city] WITH CHECK ADD CONSTRAINT [FK_city_state]
--FOREIGN KEY(state_abbreviation) REFERENCES [state] (state_abbreviation)

