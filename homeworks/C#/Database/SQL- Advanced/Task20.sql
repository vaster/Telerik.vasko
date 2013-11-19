--Write SQL statements to update some of the records in the Users and Groups tables.


update TelerikUsers
set
	UserPassword = '12a3123adas'
go

update TelerikGroups
set
	Name = 'betterNmae'
	where Name = 'Groupe13'
go