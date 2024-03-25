use Training_SQL

--Q.1 Write a T-SQL Program to find the factorial of a given number.

--declaring and setting the values to calculate factorial of a number
begin
declare @i int
set @i = 1
declare @result int
set @result = 1
declare @number int
set @number = 10
--performing the loop operation
while @i <= @number 
begin
set @result = @result * @i
set @i = @i + 1
End

--printing the result/factorial of given number
print 'Factorial of given number is:' + cast(@result as varchar(10))
End


--Q.2 
--Create a stored procedure to generate multiplication tables up to a given number.

Create or alter procedure Generate_Multiplication_Table
 @number int
as
Begin
   --Declaring the variables to hold the multiplier and multiplicand
   Declare @m int --Multiplier
   set @m = 1
   Declare @n int  --Multiplicand

   --creating table to store the multiplication table
   Create table #Multiplication_Table1(Multiplicand int,Multiplier int,Result int)
  
   --Loop through each multiplier up to maximum number
   while @m <= @Number
   begin
       set @n = 1
      ----Loop through each multiplicand up to 10
       while @n <= 10 
	   begin
		  --inserting values/multiplication into table
		  Insert into #Multiplication_Table1(Multiplicand ,Multiplier ,Result)
		  values(@m, @n, @m * @n)
		  --increament the multiplicand
	      set @n = @n + 1
	   end 
	   --increament the multiplier
	   set @m = @m +1
   end
   Select * from #Multiplication_Table1
End

--To excute the above procedure
exec Generate_Multiplication_Table @Number = 10





--Q.3 Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", 
--you cannot manupulate" etc.
--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details.
--try to match and stop manipulation 


--Creating Employee table
Create table Employee_Ass4(Emp_no numeric(7), Emp_Name varchar(30), Job varchar(35),
Salary numeric, Joining_date date)


--inserting values into Employee table
Insert into Employee_Ass4 
values(1034296,'Suryansh Dwivedi','Developer',20000,'2024-02-15'),
(1034297,'Sandeep Kumar','Developer',15000,'2023-08-15'),
(1034451,'Manoj Roy','Tester',10000,'2023-10-14'),
(1034298,'Prajesh Chaurasia','Analyst',8000,'2023-01-26'),
(1034301,'Venugopal','Project Manager',2000000,'2023-07-13'),
(1034314,'Ashok Kumar','Designer',30000,'2021-12-20')

Select * from Employee_Ass4 


--Creating Holiday Table
Create table Holiday(H_date date, H_name varchar(20))

--Inserting values in Holiday Table
Insert into Holiday values('2024-01-01', 'New Year'),('2024-01-26', 'Republic Day'),
('2024-08-15', 'Independence Day'),('2024-12-25','Chrismas Day')

--inserting values in table for checking the trigger if working properly or not
insert into Holiday values ('2024-03-25','Monday')
insert into Holiday values ('2024-03-26','Tuesday')
select * from Holiday

--Creating a trigger to restrict data manipulation on EMP table during General holidays.
create or alter Trigger Res_DataManipulation
on Employee_Ass4 
for insert,update,delete
as
begin 
    --Declaring a variable to hold the holiday name.
    Declare @Holiday_Name varchar(30)
	--Selecting holiday name from holiday table where the current date matches the holiday date.
	select @Holiday_Name=H_Name from Holiday where CONVERT(date,getdate())=H_date

	--If a holiday name is found
	if(@Holiday_name is not null)
	    --printing changes are restricted and rollback the transaction
		print'Due to' + @Holiday_Name + 'you cannot manipulate data'
		rollback
end

--if we are trying to insert these values on holidays then we can't
insert into Employee_Ass4 values
(1034353,'Suryash dwivedi','Analyst',32000,'2022-11-2')

--drop trigger if exists Res_DataManipulation

