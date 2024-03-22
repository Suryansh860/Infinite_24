create database SQL_Assessment
use SQL_Assessment

--creating books table
create table books(tid int primary key,t_title varchar(50),
auther varchar(20),isb_no numeric(20) unique,published_date datetime)

--inserting the values into the table
insert into books values(1,'My first SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My third SQL book','CaryFlint',523120967812,'2015-10-18 14:05:44')

Select * from books

--Write a query to fetch the details of the books written by author whose name ends with er.
Select * from books where auther like '%er'

Select * from books

--creating the reviews table
create table reviews(r_id int primary key, book_id int,reviewer_name varchar(30),
r_content varchar(50),rating numeric, r_published_date datetime)

--inserting values into the table
insert into reviews values(1,1,'John Smith','My first Review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','My second Review',5,'2017-10-13 15:05:12'),
(3,2,'Alice Walker','Another Review',1,'2017-10-22 23:47:10')

select * from reviews

--Display the Title ,Author and ReviewerName for all the books from the above table
Select t_title,auther,reviewer_name from books b, reviews r where b.tid = r.r_id

--Q.2
--Display the reviewer name who reviewed more than one book.
Select  reviewer_name from reviews group by reviewer_name having count(*) > 1

--Q.3
create table EMP(Id int,name varchar(20),age int,address varchar(50),salary float)

 
insert into EMP values(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan', 25,'Delhi', 1500.00),
(3,'Kaushik', 23,'Kota', 2000.00),
(4,'Chaitali', 25,'Mumbai',6500.00 ),
(5,'Hardik', 27,'Bhopal',8500.00 ),
(6,'Komal', 22,'MP', 4500.00),
(7,'Muffy', 24,'Indore',10000)

Select * from EMP 

--Display the Name for the customer from above customer table who live in same address which
--has character o anywhere in address
Select name from EMP where address like '%o%'

--Q.4
--creating order table 
create table Orders(oid int,d_date datetime, customer_id int,amount numeric(10))

--inserting values into table
insert into orders values(102,'2009-10-08',3,3000),
(100,'2009-10-08',3,1500),
(101,'2009-11-20',2,1560),
(103,'2008-05-20',4,2060)

--Write a query to display the Date,Total no of customer placed order on same Date
Select d_date, count(distinct customer_id) as Total_customers from orders group by d_date

--Q.5
create table EMP2(Id int,name varchar(20),age int,address varchar(50),salary float)

insert into EMP values(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan', 25,'Delhi', 1500.00),
(3,'Kaushik', 23,'Kota', 2000.00),
(4,'Chaitali', 25,'Mumbai',6500.00 ),
(5,'Hardik', 27,'Bhopal',8500.00 ),
(6,'Komal', 22,'MP','null'),
(7,'Muffy', 24,'Indore','null')

--Display the Names of the Employee in lower case, whose salary is null
Select lower(name) from EMP2  where salary=null

--Q.6
create table studentdetails (registerno int,name varchar(20),age int,
qualification varchar(40),mobileno varchar(15),mail_id varchar(30),location varchar(50),gender char(1))

insert into studentdetails (registerno, name, age, qualification, mobileno, mail_id, location, gender) values
(2, 'sai', 22, 'b.e', '9952836777', 'sai@gmail.com', 'chennai', 'm'),
(3, 'kumar', 20, 'bsc', '7890125648', 'kumar@gmail.com', 'madurai', 'm'),
(4, 'selvi', 22, 'b.tech', null, null, 'madurai', 'f'),
(5, 'nisha', 25, 'm.e', null, null, 'theni', 'f'),
(6, 'saisaran', 21, null, null, null, 'pune', 'f'),
(7, 'tom', 23, 'b.a bca', '8904567342', 'tom@gmail.com', 'selam', 'm')

Select * from studentdetails

--Write a sql server query to display the Gender,Total no of male and female from the above relation .
select gender,count(gender) as total from studentdetails group by gender
