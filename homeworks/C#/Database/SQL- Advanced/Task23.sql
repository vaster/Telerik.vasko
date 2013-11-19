--Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.


declare @endDate date
set @enddate = '10.03.2010'

update TelerikUsers
set
	UserPassword = null
	where Datediff(day,@endDate,LastLogin) <= 0
go