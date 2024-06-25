USE Trial;
GO;

-- Task 1
--create table
CREATE TABLE Books(
	BookID INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(MAX) NOT NULL,
	Author VARCHAR(MAX) NOT NULL,
	CoAuthor VARCHAR(MAX),
	ReleaseDate DATE
);

CREATE TABLE BooksBackup(
	BookID INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(MAX) NOT NULL,
	Author VARCHAR(MAX) NOT NULL,
	ReleaseDate DATE
);

--insert values
INSERT INTO Books VALUES ('To Kill a Mockingbird', 'Harper Lee', NULL, '1960-07-11'),
						 ('Good Omens', 'Neil Gaiman', 'Terry Pratchett', '1990-05-01'),
						 ('The Catcher in the Rye', 'J.D. Salinger', NULL, '1951-07-16'),
						 ('Brave New World', 'Aldous Huxley', 'Jack Fuller', '1932-08-18');
INSERT INTO Books(Title, Author, ReleaseDate)
				  VALUES ('1984', 'George Orwell', '1949-06-08'),
					     ('The Great Gatsby', 'F. Scott Fitzgerald', '1925-04-10'),
					   	 ('The Hobbit', 'J.R.R. Tolkien', '1937-09-21'),
						 ('The Road', 'Cormac McCarthy', '2006-09-26');
INSERT INTO Books(Title, Author)
				  VALUES ('Beloved', 'Toni Morrison');

--insert data from one table to another
INSERT INTO BooksBackup SELECT Title, Author, ReleaseDate FROM Books;

--update rows
UPDATE Books SET CoAuthor = NULL WHERE Title = 'Brave New World';
UPDATE Books SET ReleaseDate = '1987-09-16' WHERE Title = 'Beloved';

--merge two tables to modify a table
MERGE INTO BooksBackup AS bb
USING Books AS b
ON bb.BookID = b.BookID
WHEN NOT MATCHED BY TARGET THEN
INSERT VALUES (b.Title, b.Author, b.ReleaseDate);

--update a table based on the other
UPDATE BooksBackup
	SET ReleaseDate = b.ReleaseDate
FROM BooksBackup AS bb INNER JOIN Books AS b
ON bb.BookID = b.BookID
WHERE bb.ReleaseDate IS NULL
OR bb.ReleaseDate <> b.ReleaseDate;

--show table data
SELECT * FROM Books;
SELECT * FROM BooksBackup;
SELECT * FROM Books WHERE BookID = 9;
SELECT * FROM BooksBackup WHERE BookID = 9;
SELECT * FROM Books WHERE YEAR(ReleaseDate) < 1960;

--delete certain row
DELETE FROM Books OUTPUT deleted.* WHERE BookID = 9;

--delete all rows
TRUNCATE TABLE Books;

--insert id 
SET IDENTITY_INSERT Books ON;
SELECT IDENT_CURRENT('Books');
CREATE SEQUENCE dbo.BookIDSeq AS INT START WITH 9 INCREMENT BY 1;
INSERT INTO Books(BookID, Title, Author, ReleaseDate)
				  VALUES (NEXT VALUE FOR dbo.BookIDSeq, 'Beloved', 'Toni Morrison', '1987-09-16');

--delete table
DROP TABLE Books;
DROP TABLE BooksBackup;