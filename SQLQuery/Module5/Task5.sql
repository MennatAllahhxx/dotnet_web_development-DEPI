USE Northwind;
GO

-- Task 1
SELECT DISTINCT CustomerID, EmployeeID, YEAR(OrderDate) AS OrderYear 
FROM Orders 
ORDER BY OrderYear DESC;
GO

-- Task 2
SELECT DISTINCT TOP(3) CustomerID, EmployeeID, YEAR(OrderDate) AS OrderYear 
FROM Orders 
ORDER BY OrderYear DESC;
GO

-- Task 3
SELECT DISTINCT CustomerID, EmployeeID, YEAR(OrderDate) AS OrderYear 
FROM Orders 
ORDER BY OrderYear DESC
OFFSET 10 ROWS FETCH FIRST 5 ROWS ONLY;
GO