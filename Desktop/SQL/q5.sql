
-----------------CREATE--------------------
CREATE FUNCTION GetStudent1(@Std_ID INT)  
 RETURNS VARCHAR(50)  
 AS  
BEGIN  
    RETURN (SELECT Std_Name FROM Student WHERE Std_ID=@Std_ID)  
END 
--------------INVOKE----------------------------
print dbo.GetStudent1(127)

---------VALUED-----
CREATE FUNCTION GetAllStudent (@Std_ID INT)  
RETURNS TABLE  
AS  
RETURN  
    SELECT *FROM Student WHERE Std_ID>=@Std_ID 

	SELECT *FROM GetAllStudent(121)