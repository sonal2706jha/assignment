
---update coloumn
create table Student
(
	Std_Name varchar(50),
	Std_ID int,
	Roll_No int

)

ALTER TABLE Student ADD Std_Date DATE;

Truncate table Student
INSERT INTO Student(Std_Name,Std_ID,Roll_No,Std_Date)
Values('sonal',121,1,'1996-02-11')
INSERT INTO Student(Std_Name,Std_ID,Roll_No,Std_Date)
Values('neha',123,2,'1997-03-10')
INSERT INTO Student(Std_Name,Std_ID,Roll_No,Std_Date)
Values('vishesh',125,3,'1999-03-12')
INSERT INTO Student(Std_Name,Std_ID,Roll_No,Std_Date)
Values('vijay',127,4,'1996-09-21')
INSERT INTO Student(Std_Name,Std_ID,Roll_No,Std_Date)
Values('abhishek',129,5,'1995-08-01')

Select * from Student


exec sp_rename 'Student.Roll_No', 'Std_Roll'; 