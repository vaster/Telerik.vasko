USE BankDB
GO

ALTER PROC usp_RecordSelector
AS
	SELECT FirstName + ' ' + LastName
		FROM Persons
GO

EXEC usp_RecordSelector