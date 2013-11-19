--Write a SQL statement that deletes all users without passwords (NULL password).


delete from TelerikUsers
	where UserPassword is Null