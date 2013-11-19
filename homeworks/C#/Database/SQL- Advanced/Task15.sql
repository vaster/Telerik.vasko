/*
Write a SQL statement to create a table Users.
 Users should have username, password, full name and last login time. 
 Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
 Define the primary key column as identity to facilitate inserting records. Define unique constraint to avoid repeating usernames. 
 Define a check constraint to ensure the password is at least 5 characters long.
*/

create table TelerikUsers (
	UserID int identity,
	Username nvarchar(12) not null,
	UserPassword  int not null,
	FullName nvarchar(60) not null,
	LastLogin date not null,

	constraint Users primary key(UserID),
	unique(Username),
	check(len(UserPassword) >= 5)
)
go