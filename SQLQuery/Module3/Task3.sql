USE Northwind;
GO

-- Task 1
SELECT DISTINCT OrderID AS ID,
			    UnitPrice * Quantity AS TotalUnitPrice
FROM [Order Details] AS OD;
GO

-- Task 2
SELECT DISTINCT Country, City
FROM Employees;
GO

--Task 3
SELECT DISTINCT ProductID, ProductName,
CASE WHEN UnitPrice = 0 THEN 'item - not for resale'
	 WHEN UnitPrice < 50 THEN 'Under $50'
	 WHEN UnitPrice >= 50 AND UnitPrice < 250 THEN 'Under $250'
	 WHEN UnitPrice >= 250 AND UnitPrice < 1000 THEN 'Under $1000'
	 ELSE 'Over $1000'
END AS [Price Range]
FROM Products;
GO

-- Task 4
SELECT CustomerID,
	   CompanyName,
	   ContactName,
	   ISNULL(Address+ ', ' + City + ', ' + Region + ', ' + Country, Address+ ', ' + City +  ', ' + Country) AS Location
FROM Customers;
GO