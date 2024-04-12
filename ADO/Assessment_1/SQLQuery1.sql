create database Employee_Management
use Employee_Management

create table Employee_Details(Emp_No int Primary Key, Emp_Name varchar(50) not null,
Emp_Sal numeric(10,2) check (Emp_Sal >=25000),Emp_Type char(1) check (Emp_Type in('P','C')))

Select * from Employee_Details

Create or alter Proc Add_Emp_Details
@E_Name varchar(50),
@E_Sal numeric(10, 2),
@E_Type char(1)
as
Begin
    Declare @E_No int=0;
	
   
   -- Generating EmpNo
    Select @E_No = (count(Emp_No)) + 1 from Employee_Details

   -- Insert values into Employee_Details table.
    insert into Employee_Details(Emp_No,Emp_Name,Emp_Sal,Emp_Type)
	values (@E_No, @E_Name, @E_Sal, @E_Type)
End

Add_Emp_Details 'Suryansh', 50000, 'P'

Select * from Employee_Details
