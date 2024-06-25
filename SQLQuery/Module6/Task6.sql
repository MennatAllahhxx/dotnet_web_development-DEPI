USE Trial
GO

-- Task 1
CREATE TABLE Students(ID INT PRIMARY KEY IDENTITY,
					  Name VARCHAR(MAX) NOT NULL,
					  CoursesEnrolled TINYINT NOT NULL,
					  Email VARCHAR(MAX)
);
INSERT INTO Students VALUES ('ahmed', 7, 'ahmed@email.com');
INSERT INTO Students (CoursesEnrolled, Name) VALUES (6, 'mariam'),
													(7, 'samy'),
													(8, 'alaa');
SELECT * FROM Students;
GO;
