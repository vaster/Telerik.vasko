USE BankDB
GO

CREATE PROC usp_BalanceByPattern(@limit int)
AS
	SELECT Balance, p.LastName
		FROM Accounts a
	join Persons p
	ON a.PersonId = p.Id
	WHERE Balance > @limit
GO

EXEC usp_BalanceByPattern 200