use Training_SQL

Select * from EMP

--Q.1 Write a query to display your birthday( day of week)

Select datename(weekday,'2002-11-25') as day_of_week


--Q.2 Write a query to display your age in days
Select datediff(dd,'2002-11-25',getdate()) as AgeInDays

--Q.3 Write a query to display all employees information those who joined before 5 years in the current month.
Select * from EMP where datediff(yy,hiredate,getdate()) >5


--Q.4  Create table Employee with empno, ename, sal, doj columns and perform the following operations 
--in a single transaction

Begin transaction;
 
-- Creating the table
Create table employee1(empno int primary key,ename varchar(50),
sal float ,doj date)
 
 --a. First insert 3 rows 
-- Inserting values in the table
Insert into employee1 values
(1,'Suryansh',80000,'2023-06-01'),(2,'Surya',200000,'2022-05-15'),
(3,'Saurabh', 95000, '2021-11-14')

--b. Update the second row sal with 15% increment   
update employee1 
set sal = sal * 0.15 where empno = 2;
save tran t1
--c. Delete first row
delete from employee1 where empno = 1;
rollback tran t1
commit  

--After completing above all actions how to recall the deleted row without losing increment of second row.
Select * from employee1 where empno = 1


--Q.5 Create a user defined function calculate Bonus for all employees of a  given job using following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

Create or alter Function Calculate_Bonus(@deptno int)
returns float
Begin 
Declare @bonus float
Declare @sal float
Select @sal = sal from EMP where deptno = @deptno
if @deptno = 10
begin
    set @bonus = @sal * 0.15
end
else if @deptno = 20
begin 
    set @bonus = @sal * 0.20
end
else
    set @bonus = @sal * 0.05
return @bonus
End
select * from EMP
--calling the function
Select empno,ename, dbo.Calculate_Bonus(10) as bonus from EMP
