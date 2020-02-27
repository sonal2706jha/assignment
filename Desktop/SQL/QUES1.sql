create table EMP
(
EMP_ID int identity(100,1) primary key,
EMP_NAME varchar(20),
Mob_No varchar(10) Constraint TENDIGITS CHECK (Mob_no like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
DOB date,
EMP_ADDRESS varchar(20),
EMP_SALARY MONEY default null,
ZIP_CODE int check(len(ZIP_CODE)=6),
IsActive bit,
Created_date datetime default GETDATE(),
Modified_date datetime2
)

TRUNCATE TABLE EMP;
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('SONAL','9889096036','1998-06-27','DELHI',Null,232101,1)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('ARPIT','9889096078','1993-08-07','MUMBAI',Null,332101,1)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('AZEEM','9889906036','1990-06-10','ALLAHABAD',Null,232101,1)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('VIJAY','9889096360','1997-09-17','NOIDA',Null,239101,0)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('NEHA','8889096360','1995-03-18','GUJRAT',Null,539101,1)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('ABHISHEK','8589096360','1992-04-26','VARANASI',Null,239101,0)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('VISHESH','9889097360','1996-01-05','MYSORE',Null,239101,0)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('LATIKA','9880996360','1998-11-11','GAZIABAD',Null,239101,0)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('SHAGUN','7889096360','1990-09-27','RANCHI',Null,239101,1)
INSERT INTO EMP(EMP_NAME,Mob_No,DOB,EMP_ADDRESS,EMP_SALARY,ZIP_CODE,IsActive)
VALUES('PUNITA','6889096360','1991-10-02','JHANSI',Null,239101,0)

create Table SalDetail
(
emp_id int,
FOREIGN KEY(emp_id) REFERENCES EMP(EMP_ID),
sal_month varchar(50),
total_sal MONEY
)
truncate table SalDetail; 
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(101,'january',5000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(103,'februray',4000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(105,'march',8000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(101,'april',9000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(106,'may',2000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(101,'june',10000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(103,'july',15000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(105,'august',7000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(106,'september',6000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(102,'october',5000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(104,'november',9000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(107,'december',10000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(108,'january',11000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(102,'march',2000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(104,'june',12000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(109,'july',7000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(104,'may',5000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(108,'august',9000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(109,'december',3000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(107,'september',6000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(104,'march',4000)
INSERT INTO SalDetail(emp_id,sal_month,total_sal)
VALUES(102,'october',12000)



select * from EMP
select * from SalDetail

SELECT EMP.emp_id, SalDetail.total_sal
FROM EMP
FULL OUTER JOIN SalDetail ON Emp.EMP_ID=SalDetail.emp_id
ORDER BY EMP.emp_id

SELECT emp_id, SUM (total_sal),
COUNT(emp_id)
FROM SalDetail 
GROUP BY emp_id;

update EMP
set EMP.EMP_SALARY=SalDetail.Salary
from EMP inner join
(SELECT emp_id,SUM(total_sal) as Salary
FROM SalDetail 
GROUP BY emp_id)
as SalDetail on EMP.EMP_ID = SalDetail.emp_id

select * from EMP