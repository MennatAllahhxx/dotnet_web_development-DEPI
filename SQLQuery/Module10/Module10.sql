--subquery
SELECT EmployeeID FROM Employees WHERE FirstName = 'Nancy';
SELECT * FROM Orders WHERE EmployeeID = (SELECT EmployeeID FROM Employees WHERE FirstName = 'Nancy');
GO;

--from on where group by having  select order by top
-- join is faster than subquery

SELECT COUNT(*), SUM(Quantity), MAX(UnitPrice), MIN(UnitPrice), AVG(UnitPrice) FROM [Order Details];
GO;
