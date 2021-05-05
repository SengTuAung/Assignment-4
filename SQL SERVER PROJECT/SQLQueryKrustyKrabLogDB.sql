DROP DATABASE IF EXISTS KrustyKrabLogDB;  
CREATE DATABASE KrustyKrabLogDB;

DROP TABLE IF EXISTS [dbo].[Information];  

CREATE TABLE [dbo].[Information]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Date] DATETIME NULL, 
    [Name] VARCHAR(45) NULL, 
    [Supervisor] VARCHAR(45) NULL, 
    [Note] VARCHAR(250) NULL
);
GO
INSERT INTO [dbo].[Information] VALUES (1,'2010-10-20','Peter','Mike Smith','Today at work, I had to make too much Krabby Patties');
INSERT INTO [dbo].[Information] VALUES (2,'2020-01-20','Test','Test','Test');
INSERT INTO [dbo].[Information] VALUES (3,'2001-06-20','Peter','Clark','Test');
INSERT INTO [dbo].[Information] VALUES (4,'1989-01-10','Mark','Smith','Notes');
INSERT INTO [dbo].[Information] VALUES (5,'1999-07-23','Brad','Smith','Notes');
INSERT INTO [dbo].[Information] VALUES (6,'2022-04-20','Mary','Clark','Notes');
INSERT INTO [dbo].[Information] VALUES (7,'2021-04-29','Peter','Mike','Notes');

GO