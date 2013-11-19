USE BankDB
GO

ALTER PROC usp_CalculateBalanceForAccount(@AccountId int, @InterestRate int)
AS
	UPDATE Accounts
	SET Balance = [dbo].[ufn_BalanceCalculator](200,@InterestRate,1)
	where Id = @AccountId
GO

EXEC usp_CalculateBalanceForAccount 1,10