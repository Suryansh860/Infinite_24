--Using the database 
use Training_SQL

Select * from EMP
Select * from DEPT

--1.Retrieve a list of MANAGERS. 
Select mgr_id,ename as Managers_Name from EMP where job = 'MANAGER'
 
--2.Find out the names and salaries of all employees earning more than 1000 per month.
Select ename,sal from EMP where sal > 1000

--3.Display the names and salaries of all employees except JAMES.
Select ename,sal from EMP where ename != 'JAMES'

--4.Find out the details of employees whose names begin with ‘S’.
Select * from EMP where ename like 's%'

--5.Find out the names of all employees that have ‘A’ anywhere in their name.
Select ename from EMP where ename like '%a%'

--6.Find out the names of all employees that have ‘L’ as their third character in their name. 
Select ename from EMP where ename like '__L%'

--7.Compute daily salary of JONES.
Select sal/31 as Daily_sal from EMP where ename = 'jones'

--8.Calculate the total monthly salary of all employees. 
Select sum(sal) as total_Monthly_Salary_of_All from EMP

--9.Print the average annual salary. 
Select avg(sal) as Average_Salary from EMP

--10.Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
Select ename, job, sal, deptno from EMP where job != 'salesman' and deptno = 30

--11.List unique departments of the EMP table. 
Select distinct(deptno) as UniqueDept from EMP 

--12.List the name and salary of employees who earn more than 1500 and are in department 10 or 30.
--Label the columns Employee and Monthly Salary respectively.
Select ename as Emp_name,sal as Monthly_Sal,deptno from EMP where sal > 1500 and deptno in(10,30)

--13.Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST 
--and their salary is not equal to 1000, 3000, or 5000. 
Select ename, job, sal from EMP where job in('Manager','Analyst') and sal not in(1000,3000,5000)

--14.Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%.
Select ename,sal,comm,sal*1.10 as New_Salary from EMP where comm > sal

--15.Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782. 
select ename from EMP where ename like '%l%l%' and deptno=30 or mgr_id=7782

--16.Display the names of employees with experience of over 30 years and under 40 yrs.
-- Count the total number of employees. 
select ename from EMP where datediff(yy,hiredate,getdate()) between 30 and 40
Select count(*) as Total_Employees from EMP where datediff(yy,hiredate,getdate()) between 30 and 40

--17.Retrieve the names of departments in ascending order and their employees in descending order. 
Select d.dname,e.ename from DEPT d
Left join EMP e on e.deptno = d.deptno
Order by dname, ename desc  

--18.Find out experience of MILLER. 
Select ename,datediff(yy,hiredate,getdate()) as Experience 
from EMP where ename = 'MILLER'


