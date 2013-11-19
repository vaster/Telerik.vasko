CREATE PROC dbo.usp_WithdrawMoney (@accountID INT, @money money)
AS
BEGIN TRAN
 UPDATE Accounts
 SET Balance = Balance - @money
 WHERE Id = @accountID
COMMIT TRAN
GO
 
--drop proc dbo.usp_WithdrawMoney
 
CREATE PROC dbo.usp_DepositMoney (@accountID INT, @money money)
AS
BEGIN TRAN
 UPDATE Accounts
 SET Balance = Balance + @money
 WHERE Id = @accountID
 COMMIT TRAN
GO
 
EXEC dbo.usp_WithdrawMoney 2, 50
EXEC dbo.usp_WithdrawMoney 1, 50
EXEC dbo.usp_DepositMoney 1, 200
GO