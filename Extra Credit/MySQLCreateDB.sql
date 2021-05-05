DROP DATABASE IF EXISTS krustykrablogdb;  
CREATE DATABASE krustykrablogdb;

CREATE TABLE `krustykrablogdb`.`information` (
  `ID` INT NOT NULL,
  `Date` DATE NULL,
  `Name` VARCHAR(45) NULL,
  `Supervisor` VARCHAR(45) NULL,
  `Note` VARCHAR(150) NULL,
  PRIMARY KEY (`ID`),
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) VISIBLE);
  
USE krustykrablogdb;
INSERT INTO `information` VALUES (1,'2010-10-20','Peter','Mike Smith','Today at work, I had to make too much Krabby Patties'),(2,'2020-01-20','Test','Test','Test'),(3,'2001-06-20','Peter','Clark','Test'),(4,'1989-01-10','Mark','Smith','Notes'),(5,'1999-07-23','Brad','Smith','Notes'),(6,'2022-04-20','Mary','Clark','Notes'),(7,'2021-04-29','Peter','Mike','Notes');