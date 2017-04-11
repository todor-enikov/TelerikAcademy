use TelerikAcademy
--Write a SQL query to find the names and salaries of the employees that take the minimal salary
-- in the company.
-- Use a nested SELECT statement.
--------------------------------------
SELECT e.FirstName, e.Salary
FROM Employees e
WHERE e.Salary = (
	SELECT MIN(es.Salary)
	FROM Employees es)

--Write a SQL query to find the names and salaries of the employees that 
--have a salary that is up to 10% higher than the minimal salary for the company.
--------------------------------------
SELECT e.FirstName,e.Salary
FROM Employees e
WHERE e.Salary <= 0.1*(SELECT MIN(es.Salary)
						FROM Employees es)+
					  (SELECT MIN(es.Salary)
						FROM Employees es)

--Write a SQL query to find the full name, salary and department of the 
--employees that take the minimal salary in their department.
-- Use a nested SELECT statement.
--------------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full name],e.Salary,d.Name AS [Departament name]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE e.Salary IN (SELECT MIN(es.Salary)
				  FROM Employees es
				  WHERE es.DepartmentID = d.DepartmentID
				  ) 
ORDER BY e.Salary

--Write a SQL query to find the average salary in the department #1.
--------------------------------------
SELECT d.Name AS [Departament name], d.DepartmentID, AVG(e.Salary) AS [Average Salary]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name,d.DepartmentID
HAVING d.DepartmentID = 1

--Write a SQL query to find the average salary in the "Sales" department.
--------------------------------------
SELECT d.Name AS [Departament name],AVG(e.Salary) AS [Average salary]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
HAVING d.Name = 'Sales'


--Write a SQL query to find the number of employees in the "Sales" department.
--------------------------------------
SELECT d.Name AS [Departament name], COUNT(*) AS [Count of employees]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
HAVING d.Name = 'Sales'

--Write a SQL query to find the number of all employees that have manager.
--------------------------------------
SELECT COUNT(*) AS [Count of employees thath have manager]
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--Write a SQL query to find the number of all employees that have no manager.
--------------------------------------
SELECT COUNT(*) AS [Count of employees that does not have manager]
FROM Employees e
WHERE e.ManagerID IS NULL

--Write a SQL query to find all departments and the average salary for each of them.
--------------------------------------
SELECT d.Name AS [Departament name], AVG(e.Salary)
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

--Write a SQL query to find the count of all employees in each department and for each town.
--------------------------------------
SELECT COUNT(*) AS [Count of all employees],d.Name AS [Departament name],t.Name AS [Town name]
FROM Employees e
	INNER JOIN Departments d
	 ON e.DepartmentID = d.DepartmentID
		INNER JOIN Addresses a
			ON e.AddressID = a.AddressID
				INNER JOIN Towns t
					ON a.TownID = t.TownID
WHERE e.DepartmentID = d.DepartmentID AND e.AddressID = a.AddressID AND a.TownID = t.TownID
GROUP BY d.Name,t.Name

--Write a SQL query to find all managers that have exactly 5 employees.
--Display their first name and last name.
--------------------------------------
SELECT m.FirstName, COUNT(m.EmployeeID) AS [Count of employees]
FROM Employees e
	INNER JOIN Employees m
		ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName
HAVING COUNT(m.EmployeeID) = 5

--Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".
--------------------------------------
SELECT e.FirstName + ' ' + e.LastName as [Employee Name],
	   ISNULL(m.FirstName + ' ' + m.LastName, '(no manger)') as [Manager Name]
FROM Employees e
	LEFT OUTER JOIN Employees m
ON	e.ManagerID = m.EmployeeID
	
--Write a SQL query to find the names of all employees whose last name is exactly 
--5 characters long. Use the built-in LEN(str) function.
--------------------------------------
SELECT e.FirstName + ' ' + e.LastName as [Employee Name]
FROM Employees e
WHERE LEN(e.LastName) = 5

--Write a SQL query to display the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds".
--    Search in Google to find how to format dates in SQL Server.
--------------------------------------
SELECT CONVERT(VARCHAR(50),GETDATE(),3) + ' ' + 
	   CONVERT(VARCHAR(50),GETDATE(),14) AS [Current Date Time]
--http://www.w3schools.com/sql/func_convert.asp

--Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--    Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--    Define the primary key column as identity to facilitate inserting records.
--    Define unique constraint to avoid repeating usernames.
--    Define a check constraint to ensure the password is at least 5 characters long.
--------------------------------------
CREATE TABLE Users (
	id int NOT NULL IDENTITY PRIMARY KEY,
	username nvarchar(100) UNIQUE NOT NULL,
	passHash nvarchar(160) NOT NULL,
	fullname nvarchar(160), 
	lastlogin datetime)

/* GO executes everything above and starts a new batch of commands 
   it's here to prevent the command below from whining) */
GO 

--Write a SQL statement to create a view that displays the users from the Users table that 
--have been in the system today.
--    Test if the view works correctly.
--------------------------------------
CREATE VIEW UsersDefaultView AS
	SELECT u.username, u.lastlogin
	FROM TelerikAcademy.dbo.Users u
GO

SELECT * FROM UsersDefaultView

--Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--    Define primary key and identity column.
--------------------------------------
USE TelerikAcademy

CREATE TABLE Groups (
	id int NOT NULL IDENTITY PRIMARY KEY,
	name nvarchar(50) UNIQUE)

--Write a SQL statement to add a column GroupID to the table Users.
--    Fill some data in this new column and as well in the `Groups table.
--    Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
--------------------------------------
ALTER TABLE Users 
	ADD GroupID int

ALTER TABLE Users	
	ADD CONSTRAINT FK_USERS_GROUPS
		FOREIGN KEY(GroupID)
REFERENCES Groups(id)

--Write SQL statements to insert several records in the Users and Groups tables.
--------------------------------------
INSERT INTO Users (username, passHash, groupid)
	VALUES
	('me', '12345o', 1),
	('myeself', '12345p', 1),
	('and I', '12345q', 1)
		
INSERT INTO Groups (name)
	VALUES 
	('2'),
	('3'),
	('5'),
	('7')

--Write SQL statements to update some of the records in the Users and Groups tables.
--------------------------------------
UPDATE Users
SET username='Pesho'
WHERE id = 1 

UPDATE Groups
SET name = 'gosho'
WHERE name = '2'

--Write SQL statements to delete some of the records from the Users and Groups tables.
--------------------------------------
DELETE FROM Users
WHERE username = 'Pesho'

DELETE FROM Groups
WHERE name = 'gosho'

--Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--    Combine the first and last names as a full name.
--    For username use the first letter of the first name + the last name (in lowercase).
--    Use the same for the password, and NULL for last login time.
--------------------------------------
INSERT INTO Users ( username, passhash, fullname)
	SELECT LOWER(LEFT(e.FirstName, 1) + e.LastName), 
		   LOWER(LEFT(e.FirstName, 1) + e.LastName), 
		   e.FirstName + ' ' + e.LastName
FROM Employees e

--Write a SQL statement that changes the password to NULL for all users that have not
--been in the system since 10.03.2010.
--------------------------------------
UPDATE Users
SET passhash = NULL
WHERE CONVERT(datetime, lastlogin, 1) < CONVERT(datetime, '03/10/10', 1) OR lastlogin IS NULL

--Write a SQL statement that deletes all users without passwords (NULL password).
--------------------------------------
DELETE FROM Users
WHERE passhash IS NULL

--Write a SQL query to display the average employee salary by department and job title.
--------------------------------------
SELECT AVG(e.Salary) AS [Average salary],e.JobTitle,d.Name AS [Departament name]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle,d.Name
ORDER BY AVG(e.Salary)

--Write a SQL query to display the minimal employee salary by department and 
--job title along with the name of some of the employees that take it.
--------------------------------------
SELECT MIN(e.Salary) as [MinimumSalary], d.Name as [DepartmentName], e.JobTitle, (
	SELECT TOP(1) em.FirstName + ' ' + em.LastName
	FROM Employees em
	WHERE em.Salary = MIN(e.Salary)) as [Employee]
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID
GROUP BY e.DepartmentID, e.JobTitle, d.Name
ORDER BY AVG(e.Salary) DESC

--Write a SQL query to display the town where maximal number of employees work.
--------------------------------------
SELECT TOP 1 t.Name, Count(*) AS [Count of employees]
FROM Employees e
	INNER JOIN Addresses a
		ON e.AddressID = a.AddressID
	INNER JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY COUNT(*) DESC

--Write a SQL query to display the number of managers from each town.
--------------------------------------
SELECT COUNT(*) AS [Count of managers], t.Name AS [Town name]
FROM Employees m
	INNER JOIN Addresses a
		ON m.AddressID = a.AddressID
	INNER JOIN Towns t
		ON a.TownID = t.TownID
WHERE m.ManagerID IS NULL
GROUP BY t.Name

SELECT t.Name as [TownName], COUNT(*) as [ManagersCount]
FROM Employees e, Addresses a, Towns t
WHERE e.EmployeeID IN (
	SELECT m.ManagerID
	FROM Employees m) AND
	e.AddressID = a.AddressID AND
	a.TownID = t.TownID
GROUP BY t.Name 
ORDER BY COUNT(*) DESC
--Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
--    Don't forget to define identity, primary key and appropriate foreign key.
--    Issue few SQL statements to insert, update and delete of some data in the table.
--    Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--        For each change keep the old record data, the new record data and the command (insert / update / delete).
--Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
--    At the end rollback the transaction.
--Start a database transaction and drop the table EmployeesProjects.
--    Now how you could restore back the lost table data?
--Find how to use temporary tables in SQL Server.
--    Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.
CREATE TABLE WorkHours (
	id int IDENTITY PRIMARY KEY,
	employeeid int,
	dates datetime,
	task nvarchar(200),
	hoursWorked int,
	comments ntext)

ALTER TABLE WorkHours	
	ADD CONSTRAINT FK_WORKHOURS_EMPLOYEES
		FOREIGN KEY(EmployeeID)
		REFERENCES Employees(EmployeeID)

CREATE TABLE WorkHoursLogs (
	id int IDENTITY PRIMARY KEY,
	changeTime datetime,
	changeType nvarchar(50))

--START HERE to add triggers
USE TelerikAcademy
GO
CREATE TRIGGER ONINSERT
ON TelerikAcademy.dbo.WorkHours
AFTER INSERT
AS
	INSERT INTO TelerikAcademy.dbo.WorkHoursLogs 
		VALUES(GETDATE(), 'INSERT')
GO
CREATE TRIGGER ONUPDATE
ON TelerikAcademy.dbo.WorkHours
AFTER UPDATE
AS
	INSERT INTO TelerikAcademy.dbo.WorkHoursLogs 
		VALUES(GETDATE(), 'UPDATE')
GO
CREATE TRIGGER ONDELETE
ON TelerikAcademy.dbo.WorkHours
AFTER DELETE
AS
	INSERT INTO TelerikAcademy.dbo.WorkHoursLogs 
		VALUES(GETDATE(), 'DELETE')
 --END HERE to end triggers
 GO

 USE TelerikAcademy
 INSERT INTO WorkHours (dates)
	VALUES(GETDATE())

/* Transaction */
USE TelerikAcademy

BEGIN TRANSACTION
DELETE FROM Users
ROLLBACK TRANSACTION