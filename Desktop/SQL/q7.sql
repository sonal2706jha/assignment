
------Inner join----
SELECT Student.Std_ID, student_copy.Std_Name
FROM student_copy
INNER JOIN Student ON student_copy.Std_ID=Student.Std_ID;

--------------------FULL OUTER JOIN---------------------------------------------------

SELECT Student.Std_ID, student_copy.Std_Name
FROM student_copy
FULL OUTER JOIN Student ON student_copy.Std_ID=Student.Std_ID;

----------------------------------LEFT OUTER JOIN--------------------------------------
SELECT Student.Std_ID, student_copy.Std_Name
FROM student_copy
Left outer JOIN Student ON student_copy.Std_ID=Student.Std_ID;
-------------------------------------RIGHT OUTER JOIN-------------------------------
SELECT Student.Std_ID, student_copy.Std_Name
FROM student_copy
Right outer JOIN Student ON student_copy.Std_ID=Student.Std_ID;
----------------------------SELF JOIN------------------------------------------
SELECT a.Std_NAME,b.Std_NAME FROM Student a,Student b
where a.Std_ID=b.STD_ID;
