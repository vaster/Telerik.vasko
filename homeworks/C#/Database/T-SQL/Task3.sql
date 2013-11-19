USE BankDB
GO

CREATE FUNCTION ufn_BalanceCalculator(@sum money, @interestRate int, @months int)
	RETURNS money
AS
BEGIN
	RETURN (@interestRate * @months*@sum) + @sum	
END
GO

DECLARE @result money
SET @result = dbo.ufn_BalanceCalculator(100,5,12)

select @result
GO