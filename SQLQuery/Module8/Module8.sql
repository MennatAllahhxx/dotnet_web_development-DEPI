SELECT GETDATE();
SELECT YEAR(GETDATE());
SELECT DATEADD(YEAR, 2, GETDATE());
GO;

USE Northwind;
GO;

SELECT EmployeeID, FirstName, YEAR(HireDate) FROM Employees;
GO;

SELECT EmployeeID, FirstName, CAST(HireDate AS date) AS [date only] FROM Employees;
GO;

SELECT EmployeeID, FirstName, CONVERT(date, HireDate) AS [date only] FROM Employees;
GO;

-- month - day - year

SELECT SUBSTRING('microsoft sql language', 11, 3);
GO;

DECLARE @Price INT = 40;
SELECT FORMAT(@Price, 'c', 'en-us'),
	   FORMAT(@Price, 'c', 'en-DE');
GO;

SELECT * FROM Orders;
SELECT COUNT(*) FROM Orders;
SELECT COUNT(region), COUNT(employeeId) FROM Employees;
SELECT COUNT(*) AS Counter, EmployeeID FROM Orders WHERE EmployeeID IN (1,2,3,4) GROUP BY EmployeeID HAVING COUNT(*) < 125;
GO;
