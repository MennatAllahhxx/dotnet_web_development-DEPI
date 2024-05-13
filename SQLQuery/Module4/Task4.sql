USE Northwind;
GO

-- Task 1
SELECT O.OrderID, Emp.FirstName +' '+ Emp.LastName  [Employee Full Name], P.ProductName, OD.Quantity
FROM Orders AS O
JOIN Employees AS Emp
ON O.EmployeeID = Emp.EmployeeID
JOIN [Order Details] AS OD
ON OD.OrderID = O.OrderID
JOIN Products AS P
ON P.ProductID = OD.ProductID
WHERE O.OrderID = 10255;
GO