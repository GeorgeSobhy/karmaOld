CREATE DATABASE karma;
USE karma;
CREATE TABLE served(
served_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
served_name nvarchar(100) NOT NULL UNIQUE,
served_grade int,
served_phone nvarchar(11) ,
served_confession_father nvarchr(50) ,
served_birthday date
served_addationDate date NOT NULL default GETDATE()
);

CREATE TABLE meetings(
meetings_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
meetings_date date NOT NULL);

CREATE TABLE attend(
served_id int FOREIGN KEY REFERENCES served(served_id),
meetings_id int FOREIGN KEY REFERENCES meetings(meetings_id),
bible bit default '0' NOT NULL,
notebook bit default '0' NOT NULL,
attendence_date dateTime NOT NULL default GETDATE()
PRIMARY KEY(served_id,meetings_id));
