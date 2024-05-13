USE Northwind;
GO

SELECT * FROM [Order Details] WHERE OrderID = 10248
SELECT * FROM Orders WHERE OrderID = 10248
SELECT * FROM Products WHERE ProductID = 11


SELECT OD.OrderID, P.ProductName, OD.UnitPrice, OD.Quantity, OD.Discount
FROM Products AS P
JOIN [Order Details] AS OD
ON P.ProductID = OD.ProductID;
GO

SELECT * FROM Employees;
GO

SELECT Emp.EmployeeID, Emp.FirstName, ISNULL(Manager.FirstName, 'Boss') AS Manager
FROM Employees AS Emp LEFT JOIN Employees AS Manager
ON Manager.EmployeeID = Emp.ReportsTo;
GO

SELECT *
FROM Employees AS Emp1, Employees AS Emp2
WHERE Emp1.EmployeeID <> Emp2.EmployeeID AND Emp1.HireDate = Emp2.HireDate;
GO

