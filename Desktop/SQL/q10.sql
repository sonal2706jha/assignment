----function:Function will return one value always.
--*fuction have only one input parameter.
--function can  call procedure.
--function allows only select statement.

CREATE FUNCTION func1()
RETURNS varchar(20)
AS 
BEGIN
	 RETURN 'Hello ttn'
END

select dbo.func1() as regards
 
-------------------------------
CREATE PROCEDURE PRO
AS
PRINT 'HELLO TTN'
exec PRO
---procedure:It cannot call function.
--*It allows only DML statements.
---*it may have both input parameter and output parameter