--windows function
SELECT COUNT(*) FROM Employees;
SELECT * FROM Orders;
SELECT COUNT(*) FROM Orders;
SELECT COUNT(*) OVER(), * FROM Orders;

--row_number -> just gives a row number
SELECT * FROM Products;
SELECT ROW_NUMBER() OVER(ORDER BY UnitPrice) AS ID, ProductName, CategoryID, UnitPrice FROM Products;
GO;

--rank -> 
SELECT RANK() OVER(ORDER BY UnitPrice) AS [Rank], ProductName, CategoryID, UnitPrice FROM Products;
GO;

--dense_rank
SELECT DENSE_RANK() OVER(ORDER BY UnitPrice) AS [Rank], ProductName, CategoryID, UnitPrice FROM Products;
GO;

--partition
--row_number -> just gives a row number
SELECT * FROM Products;
SELECT ROW_NUMBER() OVER(PARTITION BY CategoryID ORDER BY UnitPrice) AS ID, ProductName, CategoryID, UnitPrice FROM Products;
GO;

--rank -> 
SELECT RANK() OVER(PARTITION BY CategoryID ORDER BY UnitPrice) AS [Rank], ProductName, CategoryID, UnitPrice FROM Products;
GO;

--dense_rank
SELECT DENSE_RANK() OVER(PARTITION BY CategoryID ORDER BY UnitPrice) AS [Rank], ProductName, CategoryID, UnitPrice FROM Products;
GO;
