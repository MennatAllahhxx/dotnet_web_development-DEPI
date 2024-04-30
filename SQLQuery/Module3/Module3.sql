USE Northwind;

GO

SELECT ProductID, ProductName, UnitPrice, UnitsInStock, UnitPrice * UnitsInStock AS total  FROM Products;

GO

SELECT DISTINCT City, Country FROM Employees;

GO

SELECT FirstName + ' ' + LastName AS FullName, Address + ', ' + City +', ' + Country as FullAddress FROM Employees;

GO

SELECT FirstName,
CASE Country WHEN 'USA' THEN 'American'
			 WHEN 'UK' THEN 'British'
END AS Nationality
FROM Employees;

GO

SELECT ProductName, UnitPrice,
CASE WHEN UnitPrice > 0 AND UnitPrice <= 10 THEN 'Low'
	 WHEN UnitPrice > 11 AND UnitPrice <= 50 THEN 'Medium'
	 WHEN UnitPrice > 51 AND UnitPrice <= 200 THEN 'High'
	 ELSE 'Over'
END AS StatusUnitPrice
FROM Products;