
---copy table
create table student_copy
(
	Std_Name varchar(50),
	Std_ID int,
	Std_Roll int
	)

Insert into student_copy (Std_ID,Std_Name,Std_Roll)
SELECT Std_ID,Std_Name,Roll_No  FROM Student;

select * from student_copy