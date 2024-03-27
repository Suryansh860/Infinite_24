--using our previous database where a table exists with salary 
use Training_SQL

Select * from Employees

--Write a T-Sql based procedure to generate complete payslip of a given employee with respect to 
--the following condition.

--creating procedure which take employeeID as input
Create or alter procedure Gen_Com_Payslip  @Emp_no int
as
Begin
Declare @HRA float
declare @DA float
declare @PF float
declare @IT float
declare @Deduction float
declare @Gross_Salary float
declare @Net_Salary float

--To display employee salary and name with payslip
declare @salary numeric 
select @Salary = salary from Employees where Empno = @Emp_no
declare @Emp_name varchar(25)
select  @Emp_name = Ename from Employees where Empno = @Emp_no


--   a) HRA as 10% of Salary
Set @HRA = 0.1 * @salary

--   b) DA as 20% of Salary
Set @DA = 0.2 * @salary

--   c) PF as 8% of Salary
Set @PF = 0.08 * @salary

--   d) IT as 5% of Salary
Set @IT = 0.05 * @salary

--   e) Deductions as sum of PF and IT
Set @Deduction = @PF + @IT

--   f) Gross Salary as sum of Salary,HRA,DA
SET @Gross_Salary = @salary + @HRA + @DA

--   g) Net Salary as Gross Salary - Deductions
Set @Net_Salary = @Gross_Salary - @Deduction


--printing the payslip details of employees

Print 'Employee Number: ' + Cast(@Emp_no as varchar(5)) 
Print 'Employee Name: ' + Cast(@Emp_name as varchar(25))
Print 'Salary: ' + Cast(@Salary as varchar(10)) 
Print 'HRA: ' + Cast(@HRA as varchar(10)) 
Print 'DA: ' + Cast(@DA as varchar(10)) 
Print 'PF: ' + Cast(@PF as varchar(10)) 
Print 'IT: ' + Cast(@IT as varchar(10)) 
Print 'Deduction: ' + Cast(@Deduction as varchar(10)) 
Print 'Gross Salary: ' + Cast(@Gross_Salary as varchar(20)) 
Print 'Net Salary: ' + Cast(@Net_Salary as varchar(20)) 
End

--calling the procedure..........
Gen_Com_Payslip 7002