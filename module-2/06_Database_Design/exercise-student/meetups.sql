USE [master];
GO

IF DB_ID('Meetups') IS NOT NULL
BEGIN
	ALTER DATABASE [Meetups] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE [Meetups];
END

CREATE DATABASE [Meetups];
GO

USE [Meetups];
GO

CREATE TABLE members
(
	member_number		INT				IDENTITY (1,1),
	last_name			VARCHAR(50)		NOT NULL,
	first_name			VARCHAR(50)		NOT NULL,
	email_address		VARCHAR(50)		NOT NULL,
	phone_number		VARCHAR(20)		NULL,
	date_of_birth		DATE			NOT NULL,
	send_reminder_email	BIT				NOT NULL,

	CONSTRAINT pk_member_number PRIMARY KEY (member_number)
);

CREATE TABLE groups
(
	group_number INT			IDENTITY (1,1),
	name         VARCHAR(100)	NOT NULL,

	CONSTRAINT pk_group_number PRIMARY KEY (group_number)
);

CREATE TABLE events
(
	event_number		INT				IDENTITY (1,1),
	group_number		INT				NOT NULL,
	name				VARCHAR(100)	NOT NULL UNIQUE,
	description			VARCHAR(300)	NOT NULL,
	start_date_time		SMALLDATETIME	NOT NULL,
	duration_minutes	INT				CHECK (duration_minutes > 30) NOT NULL,	

	CONSTRAINT pk_event_number PRIMARY KEY (event_number),
	CONSTRAINT fk_group_number FOREIGN KEY (group_number) REFERENCES groups(group_number)
);

CREATE TABLE group_member
(
	group_number	INT		NOT NULL,
	member_number	INT		NOT NULL,

	CONSTRAINT pk_group_member PRIMARY KEY (group_number, member_number),
	CONSTRAINT fk_group_member_member FOREIGN KEY (member_number) REFERENCES members (member_number),
	CONSTRAINT fk_group_member_group FOREIGN KEY (group_number) REFERENCES groups (group_number)
);

CREATE TABLE event_member
(
	event_number	INT		NOT NULL,
	member_number	INT		NOT NULL,

	CONSTRAINT pk_event_member PRIMARY KEY (event_number, member_number),
	CONSTRAINT fk_event_member_member FOREIGN KEY (member_number) REFERENCES members (member_number),
	CONSTRAINT fk_event_member_group FOREIGN KEY (event_number) REFERENCES events (event_number)

);





INSERT INTO [members] (last_name, first_name, email_address, phone_number, date_of_birth, send_reminder_email) VALUES ('Simpson', 'Homer', 'simpson.homer@snpp.org', '513-555-1234', '5/10/1955', 1) 
INSERT INTO [members] (last_name, first_name, email_address, phone_number, date_of_birth, send_reminder_email) VALUES ('Carlson', 'Carl', 'carlson.carlton@snpp.org', '513-555-1357',  '9/22/1955', 1)
INSERT INTO [members] (last_name, first_name, email_address, phone_number, date_of_birth, send_reminder_email) VALUES ('Leonard', 'Lenny', 'leonard.lenford@snpp.org', '513-555-0098',  '4/1/1955', 0)
INSERT INTO [members] (last_name, first_name, email_address, phone_number, date_of_birth, send_reminder_email) VALUES ('Szyslak', 'Moe', 'owner@moesbar.net', '513-555-2211',  '11/24/1966', 1)
INSERT INTO [members] (last_name, first_name, email_address, date_of_birth, send_reminder_email) VALUES ('Burns', 'Montgomery', 'burns.c.m@snpp.org', '9/15/1886', 0)
INSERT INTO [members] (last_name, first_name, email_address, phone_number, date_of_birth, send_reminder_email) VALUES ('Flanders', 'Ned', 'ned_flanders@leftorium.com', '513-555-1667',  '9/14/1945', 1)
INSERT INTO [members] (last_name, first_name, email_address, phone_number, date_of_birth, send_reminder_email) VALUES ('Lovejoy', 'Timothy', 'reverendlovejoy@fcos.org', '513-555-2478',  '1/27/1953', 1)
INSERT INTO [members] (last_name, first_name, email_address, date_of_birth, send_reminder_email) VALUES ('Gumble', 'Barney', 'barneyg@aol.com',  '6/30/1957', 0)
INSERT INTO [members] (last_name, first_name, email_address, phone_number, date_of_birth, send_reminder_email) VALUES ('Smithers', 'Waylon', 'smithers.waylon@snpp.org', '513-555-0099', '2/20/1961', 1)

INSERT INTO [groups] (name) VALUES ('Moe''s Bar')
INSERT INTO [groups] (name) VALUES ('First Church of Springfield')
INSERT INTO [groups] (name) VALUES ('Springfield Nuclear Power Plant')

INSERT INTO [events] (group_number, name, description, start_date_time, duration_minutes) VALUES ((SELECT group_number FROM groups WHERE name = 'Springfield Nuclear Power Plant'), 'Softball Game', 'Springfield Nuclear Power Plant vs Shelbyville Nuclear Power Plant.', '10/29/2021 11:30 AM', '150')
INSERT INTO [events] (group_number, name, description, start_date_time, duration_minutes) VALUES ((SELECT group_number FROM groups WHERE name = 'Moe''s Bar'), 'Pin Pals Bowling Night', 'It''s the monthly bowling night at Springfield Lanes!', '10/24/2021 7:00 PM', '120')
INSERT INTO [events] (group_number, name, description, start_date_time, duration_minutes) VALUES ((SELECT group_number FROM groups WHERE name = 'First Church of Springfield'), 'Weekly Prayer Meeting', 'Okily Dokily! We''ll see you in the basement of First Church of Springfield for prayer and snackerinos.', '11/12/2021 6 PM', '60')
INSERT INTO [events] (group_number, name, description, start_date_time, duration_minutes) VALUES ((SELECT group_number FROM groups WHERE name = 'Springfield Nuclear Power PLant'), 'Yearly Inspection', 'Ahoy Hoy. Be at your stations at the designated time for inspection.', '11/22/2021 8 AM', '90')

INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'Moe''s Bar'), (SELECT member_number FROM members WHERE last_name = 'Szyslak' AND first_name = 'Moe'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'Moe''s Bar'), (SELECT member_number FROM members WHERE last_name = 'Gumble' AND first_name = 'Barney'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'First Church of Springfield'), (SELECT member_number FROM members WHERE last_name = 'Flanders' AND first_name = 'Ned'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'First Church of Springfield'), (SELECT member_number FROM members WHERE last_name = 'Lovejoy' AND first_name = 'Timothy'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'Springfield Nuclear Power Plant'), (SELECT member_number FROM members WHERE last_name = 'Simpson' AND first_name = 'Homer'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'Springfield Nuclear Power Plant'), (SELECT member_number FROM members WHERE last_name = 'Smithers' AND first_name = 'Waylon'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'Springfield Nuclear Power Plant'), (SELECT member_number FROM members WHERE last_name = 'Burns' AND first_name = 'Montgomery'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'Springfield Nuclear Power Plant'), (SELECT member_number FROM members WHERE last_name = 'Leonard' AND first_name = 'Lenny'))
INSERT INTO [group_member] VALUES ((SELECT group_number FROM groups WHERE name = 'Springfield Nuclear Power Plant'), (SELECT member_number FROM members WHERE last_name = 'Carlson' AND first_name = 'Carl'))

INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Softball Game'), (SELECT member_number FROM members WHERE last_name = 'Simpson' AND first_name = 'Homer'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Softball Game'), (SELECT member_number FROM members WHERE last_name = 'Smithers' AND first_name = 'Waylon'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Softball Game'), (SELECT member_number FROM members WHERE last_name = 'Burns' AND first_name = 'Montgomery'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Softball Game'), (SELECT member_number FROM members WHERE last_name = 'Leonard' AND first_name = 'Lenny'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Softball Game'), (SELECT member_number FROM members WHERE last_name = 'Carlson' AND first_name = 'Carl'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Pin Pals Bowling Night'), (SELECT member_number FROM members WHERE last_name = 'Simpson' AND first_name = 'Homer'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Pin Pals Bowling Night'), (SELECT member_number FROM members WHERE last_name = 'Szyslak' AND first_name = 'Moe'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Pin Pals Bowling Night'), (SELECT member_number FROM members WHERE last_name = 'Leonard' AND first_name = 'Lenny'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Pin Pals Bowling Night'), (SELECT member_number FROM members WHERE last_name = 'Carlson' AND first_name = 'Carl'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Yearly Inspection'), (SELECT member_number FROM members WHERE last_name = 'Smithers' AND first_name = 'Waylon'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Yearly Inspection'), (SELECT member_number FROM members WHERE last_name = 'Burns' AND first_name = 'Montgomery'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Weekly Prayer Meeting'), (SELECT member_number FROM members WHERE last_name = 'Flanders' AND first_name = 'Ned'))
INSERT INTO [event_member] VALUES ((SELECT event_number FROM events WHERE name = 'Weekly Prayer Meeting'), (SELECT member_number FROM members WHERE last_name = 'Lovejoy' AND first_name = 'Timothy'))





