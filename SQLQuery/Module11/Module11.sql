--function TVF
USE Northwind;
GO;

CREATE FUNCTION FnOrderTotal (@OrderID int)
RETURNS TABLE
	RETURN SELECT orderId,  FROM [Order Details]

--function 
CREATE FUNCTION Fn_Hello ()
RETURNS NVARCHAR(50)
AS
BEGIN
	RETURN 'Hello World'
END
GO;

SELECT dbo.Fn_Hello();
GO;

CREATE FUNCTION Fn_Sum (@x INT, @y INT)
RETURNS INT
AS
BEGIN
	RETURN @x + @y
END
GO;

SELECT dbo.Fn_Sum(15,20);
GO;


SELECT * FROM VIEW_1;
GO;

--create temp table in the temp database that disappears with the end of the session
USE Northwind;
SELECT * INTO #X FROM Employees WHERE EmployeeID > 4; --disappeears when i disconnect
SELECT * INTO ##X FROM Employees WHERE EmployeeID > 4; --disappeears when everyone connected, disconnect
GO;

--cte -> the cte only exists for the line it is written on and deleted right after reaching the second line