use Training_SQL

--creating Employee table
create table EMP(
empno numeric(4) primary key,ename varchar(10),
job varchar(15), mgr_id int,
hiredate date,
sal float(5), comm numeric(4),
deptno numeric(2) foreign key (deptno) references DEPT(deptno)
)

--creating department table
create table DEPT(
deptno numeric(2) primary key, dname varchar(30),
loc varchar(20)
)
select * from DEPT
select * from EMP

--inserting data into created table(EMP)
insert into EMP (EMPNO, ENAME, JOB, MGR_ID, HIREDATE, SAL, COMM, DEPTNO)
values (7369, 'SMITH', 'CLERK', 7902, '17-DEC-80', 80, null, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975, null, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850, null, 30),
(7782, 'CLARK', 'MANAGER', 7839, '09-JUN-81', 2450, null, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000, null, 20),
(7839, 'KING', 'PRESIDENT', null, '17-NOV-81', 5000, null, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '23-MAY-87', 1100, null, 20),
(7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950, null, 30),
(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81', 3000, null, 20),
(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82', 1300, null, 10);

select * from EMP

--inserting values into Department table
insert into DEPT(DEPTNO, DNAME, LOC)
values (10, 'ACCOUNTING', 'NEW YORK'), 
(20, 'RESEARCH', 'DALLAS'), 
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON'); 

select * from DEPT


--1.Query for List all employees whose name begins with 'A'. 
Select * from EMP where ename like 'A%'

--2.Query for Select all those employees who don't have a manager.
Select * from EMP where mgr_id is null

--3.Query to List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
Select ename, empno, sal From EMP where sal between 1200 and 1400

--4.Query to Give all the employees in the RESEARCH department a 10% pay rise. 
--Verify that this has been done by listing all their details before and after the rise. 
Select deptno FROM DEPT Where dname = 'Research'

--Details before Pay rise
Select empno, ename, job, sal From EMP
where deptno = 20;

--Details after Pay rise
select empno, ename, Job, Sal = (Sal * 1.1) from EMP
Where deptno = 20;

--5.Query to Find the number of CLERKS employed. Give it a descriptive heading. 
Select COUNT(*) as "No. of Clerk employees" From EMP where job = 'CLERK';

--6.Query to Find the average salary for each job type and the number of people employed in each job. 
Select job, AVG(sal) as "Average salary",count(*) as "No. of Employees" From EMP Group By job


--7.Query to List the employees with the lowest and highest salary. 
--Query for lowest salary
Select ename,sal as "LOWEST SALARY" from EMP where sal = (SELECT MIN(sal) FROM EMP) 
--.Query for highest salary
Select ename,sal as "HIGHEST SALARY" from EMP where sal = (SELECT MAX(sal) FROM EMP)


--8.Query to List full details of departments that don't have any employees. 
Select * from DEPT where deptno Not in (Select DISTINCT deptno From EMP);


--9.Query to Get the names and salaries of all the analysts earning more than 1200 who are based in department 20.
--Sort the answer by ascending order of name. 
Select ename, sal From EMP where job = 'Analyst' and sal > 1200 and deptno = 20  
Order By ename ASC;

--10.Query For each department, list its name and number together with the total salary paid to employees in that department. 
Select dname, DEPT.deptno, SUM(sal) as "Total Salary" from DEPT 
JOIN EMP on DEPT.deptno = EMP.deptno
Group By dname, DEPT.deptno

--11.Query to Find out salary of both MILLER and SMITH.
Select ename, sal from EMP  where ename = 'MILLER' or ename = 'SMITH'

--12.Query for Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
Select ename from EMP where ename like 'A%'  or ename like 'M%' 
Order By ename ASC 
--we use order by to show the name of employees whose name start with 'A' first after that name of employees whose name start with 'M'


--13.Query to Compute yearly salary of SMITH. 
Select ename, sal*12 as "Yearly Salary" from EMP where ename = 'SMITH';

--14.Query to List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
Select ename, sal from EMP where sal not between 1500 and 2850

--15.Query to Find all managers who have more than 2 employees reporting to them.
Select mgr_id from EMP Group By mgr_id 
Having count(empno) > 2

