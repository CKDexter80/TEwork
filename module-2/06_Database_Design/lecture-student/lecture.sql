USE [master];
GO

IF DB_ID('ArtGallery') IS NOT NULL
BEGIN 
	ALTER DATABASE [ArtGallery] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE [ArtGallery];
END

CREATE DATABASE [ArtGallery];
GO

USE [ArtGallery];
GO

CREATE TABLE customers
(
	customerId  INT				identity(1, 1),  --not indicating PK, surrogate PK
	name		VARCHAR(100)	NOT NULL,
	address		VARCHAR(100)	NOT NULL,
	phone		VARCHAR(20)		NULL,

	CONSTRAINT ok_customer_id PRIMARY KEY (customerID)
);

CREATE TABLE artists
(
	artistID	INT				IDENTITY(1,1),
	firstName	VARCHAR(50)		NOT NULL,
	lastName	VARCHAR(50)		NOT NULL,

	CONSTRAINT pk_artist_id PRIMARY KEY (artistID)
);


CREATE TABLE art
(
	artID		INT				IDENTITY(1,1),
	title		VARCHAR(250)	NOT NULL,
	artistID	INT				NOT NULL,

	CONSTRAINT pk_art_id PRIMARY KEY (artId),
	CONSTRAINT fk_art_artist FOREIGN KEY (artistID) REFERENCES artists (artistID)
);

CREATE TABLE customer_purchases
(
	customerID	 INT				NOT NULL,
	artID		 INT				NOT NULL,
	purchaseDate DATETIME			NOT NULL,
	price		 MONEY				NOT NULL,

	CONSTRAINT pk_customer_purchases PRIMARY KEY (customerID, artID, purchaseDate), --associative tables use composite PK
	CONSTRAINT fk_customer_purchase FOREIGN KEY (customerID) REFERENCES customers (customerID),
	CONSTRAINT fk_art_purchase FOREIGN KEY (artID) REFERENCES art (artID)
);
