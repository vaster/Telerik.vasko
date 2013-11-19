--Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. 
--Test if the view works correctly.

create view [Active Users] as
	select Username from TelerikUsers
		where DATEDIFF(day,GETDATE(),LastLogin) = 0
