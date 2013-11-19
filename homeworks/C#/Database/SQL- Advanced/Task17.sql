--Write a SQL statement to create a table Groups. 
--Groups should have unique name (use unique constraint). 
--Define primary key and identity column.


create table TelerikGroups(
	GroupID int identity,
	Name nvarchar(20),

	constraint Groups unique(Name),
		primary key(GroupID)
)
go