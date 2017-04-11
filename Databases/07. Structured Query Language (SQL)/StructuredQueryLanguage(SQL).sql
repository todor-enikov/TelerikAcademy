--Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
-------------------------------
SELECT * 
FROM Departments

--Write a SQL query to find all department names.
-------------------------------
SELECT Name 
FROM Departments

--Write a SQL query to find the salary of each employee.
-------------------------------
SELECT Salary, FirstName +' '+ LastName AS [Full Name] 
FROM Employees

--Write a SQL to find the full name of each employee.
-------------------------------
SELECT FirstName +' '+ LastName AS [Full Name] 
FROM Employees

--Write a SQL query to find the email addresses of each employee (by his first and last name). 
--Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". 
--The produced column should be named "Full Email Addresses".
-------------------------------
SELECT e.FirstName +'.'+e.LastName +'@telerik.com' AS [Full Email Addresses] 
FROM Employees e

-- Write a SQL query to find all different employee salaries.
-------------------------------
SELECT 
DISTINCT e.Salary 
FROM Employees e

-- Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
-------------------------------
SELECT *
FROM Employees e
WHERE e.JobTitle ='Sales Representative' 

-- Write a SQL query to find the names of all employees whose first name starts with "SA".
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name]
FROM Employees e
WHERE e.FirstName LIKE 'SA%'

-- Write a SQL query to find the names of all employees whose last name contains "ei".
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name]
FROM Employees e
WHERE e.LastName LIKE '%ei%'

-- Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name]
FROM Employees e
WHERE e.Salary >= 20000 AND e.Salary <= 30000

-- Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name]
FROM Employees e
WHERE e.Salary = 25000 OR e.Salary = 14000 OR e.Salary = 12500 OR e.Salary = 23600 

-- Write a SQL query to find all employees that do not have manager.
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name]
FROM Employees e
WHERE e.ManagerID IS NULL

-- Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name],e.Salary 
FROM Employees e
WHERE e.Salary > 50000
ORDER BY e.Salary DESC

--  Write a SQL query to find the top 5 best paid employees.
-------------------------------
SELECT TOP 5 e.FirstName +' '+ e.LastName AS [Full Name],e.Salary 
FROM Employees e
ORDER BY e.Salary DESC

--  Write a SQL query to find all employees along with their address. Use inner join with ON clause.
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name], a.AddressText
FROM Employees e
	INNER JOIN Addresses a
		ON e.AddressID = a.AddressID

--  Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full Name], a.AddressText
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

--  Write a SQL query to find all employees along with their manager.
-------------------------------
SELECT e.FirstName AS [Employee first name], m.FirstName AS [Manager firstname]
FROM Employees e
	  INNER JOIN Employees m
		 ON e.ManagerID = m.EmployeeID

--  Write a SQL query to find all employees, along with their manager and their address. 
--  Join the 3 tables: Employees e, Employees m and Addresses a.
-------------------------------
SELECT e.FirstName + ' ' + e.LastName as [Employee], 
	   ea.AddressText as [EmployeeAddress],
	   m.FirstName + ' ' + m.LastName as [Manager],
	   em.AddressText as [ManagerAddress]
FROM Employees e
	INNER JOIN Employees m
		ON e.ManagerID = m.EmployeeID
			INNER JOIN Addresses ea
				ON e.AddressID = ea.AddressID
					INNER JOIN Addresses em
						ON e.ManagerID = m.EmployeeID AND m.AddressID = em.AddressID
							ORDER BY m.FirstName

--  Write a SQL query to find all departments and all town names as a single list. Use UNION.
-------------------------------
SELECT d.Name
FROM Departments d
UNION
SELECT t.Name
FROM Towns t

-- Write a SQL query to find all the employees and the manager for each of them along with the 
-- employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
-------------------------------
SELECT e.FirstName AS [Employee name],m.FirstName AS [Manager name]
FROM Employees e
	RIGHT OUTER JOIN Employees m
		ON e.ManagerID = m.EmployeeID

SELECT e.FirstName AS [Employee name],m.FirstName AS [Manager name]
FROM Employees e
	LEFT OUTER JOIN Employees m
		ON e.ManagerID = m.EmployeeID

-- Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" 
-- whose hire year is between 1995 and 2005.
-------------------------------
SELECT e.FirstName +' '+ e.LastName AS [Full name], d.Name, e.HireDate
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance') 
  AND (year(e.HireDate) >= 1995 OR year(e.HireDate) <= 2005)

