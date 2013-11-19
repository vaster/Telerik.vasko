CREATE TABLE Logs (
  LogID INT IDENTITY,
  OldSum money NOT NULL,
  NewSum money NOT NULL,
  AccountID INT NOT NULL,
  CONSTRAINT PK_LogID PRIMARY KEY(LogID),
  CONSTRAINT FK_Logs_Accounts
  FOREIGN KEY (AccountID)
  REFERENCES Accounts(Id)
)
GO
 
CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
 
INSERT INTO Logs (OldSum, NewSum, AccountID)
SELECT d.Balance,
           i.Balance,
           d.Id
  FROM deleted AS d
  JOIN inserted AS i
    ON d.Id = i.Id
GO
 
EXEC dbo.usp_DepositMoney 1, 200
GO