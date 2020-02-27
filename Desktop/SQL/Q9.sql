------------where------
--*we can't use where directly with aggrigate function but after having we can use this.
--*this caluse selects column before grouping.
Select * from Student
where Std_ID<=125

------------------HAVING--------------
--*We can use having only with Aggrigate function(sun,avg,min,max).
---*this caluse selects column after grouping.
SELECT COUNT(Std_ID) Std_Name
FROM Student
GROUP BY Std_Name
HAVING COUNT(Std_ID) < 125;