USE Northwind;
GO

-- Task 1 
SELECT TOP(1) Emp.EmployeeID,
	   Emp.FirstName + ' ' + Emp.LastName AS EmployeeFullName,
	   Emp.HomePhone AS EmployeeContact,
	   Emp.Address + ', ' + Emp.City + ', ' + ISNULL(Emp.Region, 'NA') + ', ' + Emp.Country AS EmployeeFullAddress,
	   COUNT(O.OrderID) AS AllOrders,
	   YEAR(O.OrderDate) AS OrderYear,
	   SUM(OD.Quantity * OD.UnitPrice * (1 - OD.Discount)) AS Total_Gained_Money
FROM Employees AS Emp
JOIN Orders AS O
ON Emp.EmployeeID = O.EmployeeID
JOIN [Order Details] AS OD
ON O.OrderID = OD.OrderID
WHERE Emp.EmployeeID not in (1, 2, 3, 6, 9)
GROUP BY Emp.EmployeeID,
		 Emp.FirstName + ' ' + Emp.LastName,
		 Emp.HomePhone,
		 Emp.Address + ', ' + Emp.City + ', ' + ISNULL(Emp.Region, 'NA') + ', ' + Emp.Country,
		 YEAR(O.OrderDate)
ORDER BY Total_Gained_Money DESC;
GO