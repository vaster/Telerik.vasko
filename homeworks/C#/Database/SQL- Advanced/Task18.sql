--Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the Groups table. 
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.



alter table TelerikUsers add GroupID int
alter table TelerikUsers
	add constraint FK_TelerikUsers_TelerikGroups
	foreign key (GroupId)
	references TelerikGroups(GroupId)