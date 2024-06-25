DECLARE @Message CHAR(20) = 'Welcome in SQL';
SELECT @Message
SET @Message = 'Hello world 046840214568415656854641'
SELECT @Message
GO;

DECLARE @x VARCHAR(20) = 'Hello SQL'
SELECT @x
GO;

DECLARE @y VARCHAR(20) = 'Hello'
SELECT @y, LEN(@y), DATALENGTH(@y)
GO;

DECLARE @z CHAR(20) = 'Hello'
SELECT @z, LEN(@z), DATALENGTH(@z)
GO;

DECLARE @Notes VARCHAR(MAX)

GO;

DECLARE @Ar NVARCHAR(50) = '???'
SELECT @Ar, LEN(@Ar), DATALENGTH(@Ar)
GO;

DECLARE @Arr NCHAR(50) = '???'
SELECT @Arr, LEN(@Arr), DATALENGTH(@Arr)
GO;

DECLARE @i int = 321115616
SELECT @i, LEN(@i), DATALENGTH(@i)
GO;

DECLARE @i decimal(30,20) = 21111561.68
SELECT @i, LEN(@i), DATALENGTH(@i)
GO;

DECLARE @i decimal(30,20) = 21111561.68
SELECT @i, LEN(@i) AS [Length], DATALENGTH(@i) AS [Size]
GO;

DECLARE @Code UNIQUEIDENTIFIER = NEWID()
SELECT @Code
GO;


