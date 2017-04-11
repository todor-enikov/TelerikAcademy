USE Bank
-- Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and 
-- Accounts(Id(PK), PersonId(FK), Balance).
-- Insert few records for testing.
-- Write a stored procedure that selects the full names of all persons.

CREATE TABLE Persons(
Id INT NOT NULL PRIMARY KEY IDENTITY,
Firstname NVARCHAR(20) NOT NULL,
Lastname NVARCHAR(20) NOT NULL,
SSN INT NOT NULL
)

CREATE TABLE Accounts(
Id INT NOT NULL PRIMARY KEY IDENTITY,
Balance MONEY NOT NULL,
Person_Id INT NOT NULL FOREIGN KEY REFERENCES Persons(Id)
)

--DROP TABLE Accounts
--DROP TABLE Persons

GO
CREATE PROC sp_Fullname
AS
	SELECT Firstname +' '+ Lastname AS [Full name]
	FROM Persons 
GO

EXEC sp_Fullname

--Create a stored procedure that accepts a number as a parameter and returns 
--all persons who have more money in their accounts than the supplied number.
GO
CREATE PROC sp_AllPersonWithMoreMoney(@number money)
AS
	SELECT p.Firstname +' '+ p.Lastname AS [Full name], a.Balance
	FROM Persons p
		INNER JOIN Accounts a
			ON p.Id = a.Person_Id
	WHERE a.Balance > @number
GO

EXEC sp_AllPersonWithMoreMoney 300

--Create a function that accepts as parameters – sum, yearly interest rate and number of months.
-- It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.

GO
CREATE FUNCTION sp_CalculatingInterest (@sum MONEY, @interestPerYear FLOAT, @monthsCount FLOAT)
RETURNS money
AS
	BEGIN
		DECLARE @interest MONEY
		SET @interest = @sum * (1 + ((@interestPerYear/100) * (@monthsCount/12)))
		RETURN @interest
	END
GO

SELECT dbo.sp_CalculatingInterest(10000,3.875,60) AS [Calculated sum]

--Create a stored procedure that uses the function from the previous example to 
--give an interest to a person's account for one month.
--It should take the AccountId and the interest rate as parameters.
GO
CREATE PROC sp_AddingInterestToAPersonForAMonth (@accountId INT, @interestRate FLOAT)
AS
	UPDATE Accounts
	SET Balance = dbo.sp_CalculatingInterest((SELECT a.Balance
				  FROM Accounts a
				  WHERE a.Id = @accountId), 
				  @interestRate,
				  1)
	WHERE Id = @accountId
GO

EXEC dbo.sp_AddingInterestToAPersonForAMonth 1,20

SELECT p.Firstname, a.Balance
FROM Accounts a
	INNER JOIN Persons p
		ON a.Person_Id = p.Id
WHERE a.Id = 1

--Add two more stored procedures WithdrawMoney(AccountId, money) 
--and DepositMoney(AccountId, money) that operate in transactions.


GO 
CREATE PROC sp_WithdrawMoney (@accountId INT, @money MONEY)
AS
	BEGIN TRAN
		UPDATE Accounts 
		SET Balance = Balance - @money
		WHERE Id = @accountId
	COMMIT
GO

EXEC sp_WithdrawMoney 1,50

SELECT *
FROM Accounts a
WHERE a.Id = 1

GO
CREATE PROC sp_DepositMoney (@accountId INT, @money MONEY)
AS
	BEGIN TRAN
		UPDATE Accounts 
		SET Balance = Balance + @money
		WHERE Id = @accountId
	COMMIT
GO

EXEC sp_DepositMoney 2,100

SELECT *
FROM Accounts a
WHERE a.Id = 2

--Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--Add a trigger to the Accounts table that enters a new entry into the Logs 
--table every time the sum on an account changes.

CREATE TABLE Logs(
LogId INT NOT NULL PRIMARY KEY IDENTITY,
AccountId INT NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
OldSum MONEY NOT NULL,
NewSum MONEY NOT NULL
)

GO
CREATE TRIGGER tr_UpdateAccounts ON Accounts AFTER UPDATE
AS
	BEGIN
		DECLARE @accountId INT,
				@oldSum MONEY,
				@newSum MONEY
		SET @accountId = (SELECT Id
						  FROM inserted)

		SET @oldSum = (SELECT Balance
						FROM deleted)

		SET @newSum = (SELECT Balance
						FROM inserted
						WHERE id = (
									SELECT id
									FROM deleted))

		INSERT INTO Logs VALUES (@accountId, @oldSum, @newSum)		
	END
GO


--Define a function in the database TelerikAcademy that returns all Employee's
--names (first or middle or last name) and all town's names that are comprised of given set of letters.
--Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
USE TelerikAcademy
GO
CREATE FUNCTION ufn_RegexSim(@matchChars nvarchar(150), @string nvarchar(150))
	RETURNS BIT
	AS
	BEGIN
		DECLARE @length int, @i int
		SET @length = LEN(@string)
		SET @i = 0
		WHILE (@i < @length)
			BEGIN
				DECLARE @char nvarchar(1)
				SET @char = SUBSTRING(@string, @i, 1)
					IF (@char LIKE '[' + @matchChars + ']')
						SET @i = @i
					ELSE
						RETURN 0
						
				SET @i = @i + 1
			END
		
		RETURN 1
	END
GO

USE TelerikAcademy

SELECT *
FROM Employees e
WHERE 1 = dbo.ufn_RegexSim('G', e.FirstName)
