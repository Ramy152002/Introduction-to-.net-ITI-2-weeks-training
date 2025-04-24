----create database CompanyDataBase;

----alter database CompanyDataBase modify name=SunRiseLtd

------stored procedures 
------sp_renameDB 'old name', 'new name'
----sp_renameDB 'SunRiseLtd','SunriseTrade'


----use master;


----alter database SunriseTrade set single_user with rollback immediate;
----drop database SunriseTrade

----create database SunriseCo 

create table Departments
(
Id int primary key identity (1,1),
Name nvarchar(50) not null, -- will store 50 char * 2 byte =100 byte for every field
Description nvarchar(max) -- best practice
);

----sp_help Departments

----select * from Departments
------full syntax
----insert into Departments(Name,Description)values('Ramy','Backend developer')

----select * from Departments
------single 
----insert into Departments values('WD','Web Development')

----select * from Departments

------multiple insert 
----insert into Departments values('BA','Business Analysis'),('HR','Human Resources');
----select * from Departments
----insert into Departments values ('QA','Quality Assurance')

----select * from Departments;
--/*

--multiple line comments
--*/

--update Departments set Name ='QC',Description='Quality Control' where Id=5;

--select * from Departments;

--delete from Departments where Id=3;
--select * from Departments;

--delete from departments
--select *from departments

--insert into departments values('QA','Quality Assurance')

--select * from departments

--truncate table departments
--insert into departments values('TM','Top Management')

--select * from departments

--truncate table departments;

insert into departments values('TM', 'Top Management');

insert into departments values('WD','Web Development'),
							  ('QA','Quality Assurance'),
							  ('BA','Business Analysis');


--select *from departments

--datetime1 01-01-1753 00:00:00 to 31-12-9999 23:59:59.997
--datatime2 01-01-0001 00:00:00 to 31-12-9999 23:59:59.9999999
--use SunriseCo;

create table Employees
(Id int primary key identity (1,1),
FullName nvarchar(60) not null,
NationalId nvarchar(14) unique,
BirthDate datetime2,
HiringDate datetime2,
Position nvarchar(30),
Country nvarchar(25) default 'Egypt',
Salary decimal (18,2)check(Salary>=6000 and Salary<=60000),
IsActive bit,
DepartmentId int foreign key references Departments(Id) on delete no action,
ManagerId int foreign key references Employees(Id) on delete no action
)
--sp_help Employees;

--use SunriseCo


--truncate table employees

--insert into Employees values('Omar Hassan Ali','10020030040055','1980/02/25 00:00:00','2005/10/15 09:00:00','CEO','Egypt',49500.75,1,1,null);
--select * from Employees;
--insert into Employees values('Bahaa Mahmoud Farid','60005000400033','1980/05/16 00:00:00','2009/11/22 09:30:00','CTO','Egypt',42000.25,1,1,1)
--insert into Employees values('Ziyad Hassan Wahid','10203040506070','1985/10/27 00:00:00','2012/12/24 09:00:00','Team Leader','Egypt',22500.00,1,1,2)
--insert into Employees values('Hossam Ahmed Ali','11122233344455','1991/10/15 00:00:00','2011/11/22 09:00:00','Team Leader','Egypt',21500,1,2,2)
--insert into Employees values('Baraa Ashraf Essam','10002000300044','1993/12/29 00:00:00','2012/12/24 09:00:00','Senior Tester','Kuwait',12500.25,1,3,4)
--insert into Employees values('Mostafa Mohammed Hassan','11022033044055','1992/11/27 00:00:00','2022/7/17 09:00:00','Senior Developer','Kuwait',15000.75,1,1,3)
--insert into Employees values('Bassam Aymen Aly','11002200330044','1997/10/15 00:00:00','2021/5/25 09:00:00','Developer','Egypt',9200,1,1,3)
--insert into Employees values('Osama Mostafa Omar','30002000100099','1998/11/25 00:00:00','2019/10/20 09:00:00','Tester','Kuwait',6400,1,3,4)
--insert into Employees values('Hossam Ahmed Ali','90008000700066','1988/10/27 00:00:00','2017/9/18 09:00:00','Developer','Kuwait',9200,1,1,3)
--insert into Employees values('Mahmoud Asharf Saad','90007000500033','1994/7/20','2020/11/03 09:00:00','Developer','Egypt',11750,1,1,3);
--insert into Employees values('Osama Omar Saad','20004000600088','1990/03/15','2010/10/30 09:00:00','Developer','Oman',12500,1,1,3);
--insert into Employees values('Bassam Sayed Allam','99988877766655','1987/12/13','2024/02/12 09:00:00','Tester','Egypt',11750,1,1,4);
--insert into Employees values('Nael Amr Mamdouh','10102020303044','1986/11/20','2020/12/24 09:00:00','Senior Developer','Kuwait',17250,1,1,3);
--insert into Employees values('Aymen Mostafa Sallam','90807060504030','1995/05/27','2023/08/28 09:00:00','Tester','Oman',19500,1,3,4);
--insert into Employees values('Wael Mostafa Farid','55544433322211','1998/10/23 00:00:00','2024/3/13 09:00:00','Tester','Egypt',9500.00,1,3,4)

--select * from employees

--create table Sectors(
--Id int primary key identity(1,1),
--Name nvarchar(50) not null,
--Description nvarchar(max)
--);

--insert Sectors values('Sec A','Sector A'),
--						('Sec B','Sector B'),
--						('Sec C','Sector C');

--select * from sectors;

--alter table sectors add Notes nvarchar(max);
----rename column in a table using stored procedure

--sp_rename 'Sectors.Notes','Summary','column';

--select * from sectors


--sp_rename 'Sectors','Divisions'
--select * from Divisions;

--alter table Divisions alter column Summary int ;
--sp_help Divisions

--drop table Divisions;

--select * from Divisions




--truncate table Employees

--select * from Employees

--drop table Employees
create table departments (
DepartmentID int identity (1,1) primary key,
name nvarchar(50) 
)















insert into Employees(FullName, NationalId, BirthDate, hiringDate, Position, Salary, IsActive, DepartmentId, ManagerId) values('Omar Hussain Ali', '10020030040055', '1980/2/25', '2005/10/15 09:00:00', 'CEO', 49500.75, 1, 1, null);

insert into Employees values('Bahaa Mahmoud Farid', '60005000400033', '1980/5/16', '2009/11/22 09:30:00', 'CTO', 'Egypt', 42000.25, 1, 1, 1);


insert into Employees values('Ziyad Hassan Wahid', '10203040506070', '1985/10/27', '2012/12/24 09:00:00','Team Leader', 'Egypt', 22500, 1, 2, 2);

insert into Employees values('Hossam Ahmed Ali', '11122233344455', '1991/10/15', '2011/11/22 09:00:00', 'Team Leader', 'Egypt', 21500.25, 1, 3, 2);

insert into Employees values('Baraa Ashraf Essam', '10002000300044', '1993/12/29', '2012/12/24 09:00:00', 'Senior Tester', 'Kuwait', 12500.25, 1, 3, 4);

insert into Employees values('Mostafa Mohammed Hassan', '11022033044055', '1992/11/27', '2022/07/17 9:00:00', 'Senior Developer', 'Kuwait', 15000.75, 1, 2, 3);

insert into Employees values('Bassam Ayman Aly', '11002200330044', '1997/10/15', '2021/05/25 09:00:00', 'Developer', 'Egypt', 9200, 1, 2, 3);

insert into Employees values('Usama Mostafa Omar', '30002000100099', '1998/11/25', '2019/10/20 09:00:00', 'Tester', 'Kuwait', 6400, 1, 3, 4);

insert into Employees values('Samir Ahmed Taha', '90008000700066', '1988/10/27', '2017/09/18 09:00:00', 'Developer', 'Kuwait', 10500, 1, 2, 3);

insert into Employees values('Mahmoud Ashraf Saad', '90007000500033', '1994/7/20', '2020/11/03 09:00:00', 'Developer', 'Egypt', 11750, 1, 2, 3);

insert into Employees values('Osama Omar Talaat', '20004000600088', '1990/3/15', '2010/10/30 09:00:00', 'Developer', 'Oman', 12500, 1, 2, 3);

insert into Employees values('Bassam Hassan Allam', '99988877766655', '1987/12/13', '2024/02/12 09:00:00', 'Tester', 'Egypt', 12500, 1, 3, 4);

insert into Employees values('Nael Amr Othman', '10102020303044', '1986/11/20', '2020/12/24 9:00:00','Senior Developer', 'Kuwait', 17250, 1, 2, 3);

insert into Employees values('Ayman Mostafa Sallam', '90807060504030', '1995/5/27', '2023/08/28 09:00:00','Tester', 'Oman', 19500, 1, 3, 4);

insert into Employees values('Wael Mostafa Farid', '55544433322211', '1998/10/23', '2024/03/13 09:00:00','Tester', 'Egypt', 9500, 1, 3, 4);

select * from Employees

-- select specific columns/fields
select fullname ,Position, Salary from Employees
--filtering
select * from Employees where Position='developer '
select fullname ,Position, Salary from Employees where Position='developer '
--not equal != <>
select * from Employees where Position!='developer'
select * from Employees where Position<>'developer'
--and 
select * from Employees where Position ='Developer' and Country='egypt'
select * from Employees where Salary>=10500 and Salary<=12500
--or 
select * from Employees where Country='huwait' or Country= 'Oman'
 --between 
 select * from Employees where Salary between 10500 and 12500
 select * from Employees where salary not between 10500 and 12500
 --in 
 select * from Employees where Country in('kuwait','Oman')
 select * from Employees where Country not in ('kuwait ','Oman')

 use SunriseCo


 -- string concatenation (Operator +) --alias
 select fullname+' ('+position+')' as employee from employees

 --wild cards
 --% -> zero or more characters 
 select * from Employees where FullName like 'ba%'
 select * from Employees where FullName like '%an'
 select * from Employees where FullName like '%am%'

 -- underscore _  -> one character 
 select * from Employees where FullName like '_sama%'
 select * from Employees where fullname like '%al_'

 --[] -> any character
 select * from Employees where FullName like '[owz]%'
 select * from Employees where FullName like '%[yw]%'
 select * from Employees where FullName like '%[dn]'


 -- not like 
 select * from Employees where FullName not like '%[dn]'
 select * from Employees where FullName not like '%[bmo]'

 --[^] not any character بدل ال not 
 select * from Employees where FullName like '[^bmo]%'


 --sorting order ascending is default 
 select * from employees order by fullname asc;
 select * from Employees order by FullName;-- default ascending
 select * from Employees order by FullName desc; -- default ascending
 
 select * from Employees order by salary asc;
 
 select * from Employees order by salary desc;

 update Employees set FullName = 'Bassam Ayman Aly' where Id = 12;

 select * from employees order by fullname asc,Salary desc;
 
 --top n 
 select top 3 * from Employees ;
 select top 3 * from Employees order by Salary asc;
 
 select top 3 * from Employees order by Salary desc;

 --distinct 
 select distinct country from Employees;
 select distinct Position from Employees;
 select distinct country, Position from Employees;
 select distinct top 3 salary from Employees order by salary desc;
  
  
  --alias 



  select FULLname as empoyee ,position as job , salary from Employees;
  select fullname as [Full Name] , position as Job ,salary from Employees
  select fullname as'Full Name ', position as Job, salary from Employees;  

  select *, (Salary *12)as [Annual Salary] from employees ;
  
  select *, (Salary *12)as 'Annual Salary' from employees ;
  
  select FullName,Position, (Salary *12)as [Annual Salary] from employees ;

  alter table employees add Annual_Salary as(salary *12) 

  sp_help employees

  select sum(salary) as 'Total salries' from Employees;
  select sum(salary) as 'Egypt Salaries' from Employees where Country ='Egypt'

  select * from Employees;
  update Employees set salary = null where id = 10;
  select * from Employees;

  select count (salary) as 'Number of Salaries ' from Employees
 select count (id) as 'Number of Employees' from Employees
 select count(*) as 'Number of Employees' from Employees;     

 select AVG(salary ) as 'Average Salary' from Employees;
 select avg(salary ) as 'Average Egypt Salary' from Employees where Country='Egypt' 

 select max(salary) as 'Maximum Salary' from Employees
 select min(salary) as 'Minimum Salary' from Employees

 --group by
 select country, count(id) as 'Number of employees' from Employees group by Country; 
 select country, count(*) as [Number of employees] from Employees group by Country; 

 select position, count(id) as [number of employees] from Employees group by Position;
 select position, count(*) as 'number of employees' from Employees group by Position;

 select country , position ,count (id) as [Number of Employees] from Employees group by country, Position;
 select country , position ,count (*) as 'Number of Employees' from Employees group by country, Position;

 select country ,sum(salary) as [Total Salaries] from employees group by country ;
 select country ,sum(salary) as 'Total Salaries' from employees group by country ;

 use SunriseCo

 select position , count(id) as ' number of EG employees'
							from Employees
							where Country='Egypt'
							group by Position

							
 select position , count(*) as  [number of EG employees]
							from Employees
							group by Position
							having COUNT(id)>1


--- variable 
-- variable declaration
-- declare @variable_name data_type ;
declare @NumberOfCustomer int;

--value assignment
--set @variable_name= value or select @Variable_nume = value
set @NumberOfCustomer=30;

--intilization
declare @JanuaryNewCustomers int =15;
set @NumberOfCustomer+= @JanuaryNewCustomers;
select @NumberOfCustomer;

select @NumberOfCustomer [Number Of Customers];
print (@NumberOfCustomer)
print @NumberOfCustomer;

declare @cost  decimal (18,2)=4000;

select 'Cost: '+ convert (varchar ,@cost)

declare @expiryDate datetime2='2026/2/15'

select 'Expiry Date: '+ convert(varchar,@expirydate ,101)

select 'Expiry Date: '+ convert(varchar,@expirydate ,102)
select 'Expiry Date: '+ convert(varchar,@expirydate ,103)
select 'Expiry Date: '+ convert(varchar,@expirydate ,104)
--**if else 
--declare @score float = 87
--if(@score>=50)
--	select 'Passed'
--	else 
--	select 'Failed'

--if(@score>=90)
--select 'Perfect'
--else if (@score >=80) select 'Very Good'
--else if (@score >=65) select 'Good'
--else if (@score >=50) select 'Passed'
--else if (@score >=40) select 'Poor'
--else select 'Very Poor'

--case (case when then else end
select fullname, position, case when country='Egypt' then 'Citizen' end  
from employees


select fullname, position, case when country='Egypt' then 'Citizen'  else 'Foreigner' end from employees


--while loop
declare @i int ;
set @i =0;
while(@i<10)
begin 
	print @i+1;
	set @i+=1;
end


declare @i int = 0;

while(@i<10)
begin
set @i+=1
if(@i%2=0) 
begin 
continue 
end
print @i
end

-- break -> stop the loop

declare @i int =0;
while(@i<10)
begin 
	set @i+=1
	print @i
	if(@i=5)
	begin 
		break;
	end

end


--join select multiple tables
--join types (1. inner join  2.outer joins (left, right, full) 3. cross join)

select * from Departments
insert into Departments values('HR','Human Resources'),('M&S','Marketing and Sales')
select * from Employees
insert into Employees values('Ashraf Osama Ayman', '10101020202030', '1997/10/27', '2024/12/24 09:00:00','Senior Technical Support', 'Egypt', 19250.75, 1, null, 2);
insert into Employees values('Khalid Wael Hassan', '40404050505060', '2000/10/15', '2024/12/29 09:00:00', 'Technical Support', 'Egypt', 15500.25, 1, null, 2);

select * from Departments inner join employees on Departments.id =Employees.DepartmentId
order by Departments.id



select Departments.Id as [Department Id] , name , Description, Employees.id as'Employee Id' , fullname , position 
from Departments inner join employees 
on Departments.id =Employees.DepartmentId
where departmentId!=1
order by Departments.id

select employees1.fullname as employee , Employees1.position , Employees2.fullname as maneger,Employees2.position 
from Employees as employees1 inner join Employees as employees2
on employees1.ManagerId = employees2.id
order by employees1.id


select* from Departments left outer join Employees
on Departments.id = Employees.DepartmentId
order by Departments.id

select* from Departments right outer join Employees
on Departments.id = Employees.DepartmentId
order by Employees.id




select* from Departments full outer join Employees
on Departments.id = Employees.DepartmentId
order by Departments.id 

--cross join 
create table chemicals
(
Id int primary key identity (1,1),
name nvarchar(50) not null
)

insert into chemicals values ('Chemical 01'),('Chemical 02'),('Chemical 03')

create table plants
(
Id int primary key identity (1,1),
name nvarchar(50) not null
)
insert into plants values ('plant 01'),('plant 02'),('plant 03')

select * from chemicals
select * from plants

select plants.name as plant ,chemicals.name as chemical  , '' as result
from plants cross join chemicals
order by plants.name


use SunriseCo;
--sub-query -> easier to read and understand but join is better in performance 
select fullname,position ,(select name from departments where id = Departmentid) as department from Employees;

-- view 
create view KuwaitEmployeeView
as select id, fullname , nationalid , birthdate ,country from Employees where Country='Kuwait';

select *from KuwaitEmployeeView;

insert into KuwaitEmployeeView (FullName, NationalId,BirthDate) values ('Wael Omar', '90908080707066','7995/3/25');

update KuwaitEmployeeView set NationalId='90008000700077' where id = 9 ;

select * from KuwaitEmployeeView;

delete from KuwaitEmployeeView where id=6;
select * from KuwaitEmployeeView;

drop view KuwaitEmployeeView;
select * from Employees;
update Employees set country ='Kuwait' where id = 18;

select * from Employees select * from Employees select * from Employees select * from Employees


SELECT DISTINCT Country FROM Employees

-- functions:
/*
1. system /built-in/pre-defined 'function'
1.1 aggregate function (sum-count-avg-min-max)
1.2 string functions

*/
select lower('SQL Server');
select upper ('SQL Server');

select '|'+ltrim('           SQL Server        ')+'|'; --|SQL Server        |
select '|'+rtrim('           SQL Server        ')+'|';--|           SQL Server|
select '|'+trim('           SQL Server        ')+'|';--|SQL Server|

select len('SQL Server')
select charindex('e','SQL Server');-- one-based index 
select REPLACE('SQL Server', 'Server','DateBase');-- string or variable , something to change , new thing

select LEFT('SQL Server',5)
select right('SQL Server',5)
select substring ('SQL Server',5,3)

--1.3 mathematical function:
select sqrt(81);

select floor(7.4)
select floor(7.6)
select floor(-7.4)
select floor(-7.6)

select ceiling(7.4)
select ceiling(7.6)
select ceiling(-7.4)
select ceiling(-7.6)


select round(3.567,0)
select round(3.567,1)
select round(3.567,2)
select round(3.567,3)

--1.4 Date and Time Functions:
select getdate();-- current date in my location 
select getutcdate();-- date in utc

select isdate('25/12/2024'); --0 
select isdate('2500/12/20'); --1 

select datename(year , '2024/12/25');
select datename(month , '2024/12/25');
select datename(day, '2024/12/25');
select datename(week , '2024/12/25');
select datename(DAYOFYEAR , '2024/12/25');
select datename(weekday , '2024/12/25');

select datepart(year , '2024/12/25');
select datepart(month , '2024/12/25');
select datepart(day, '2024/12/25');
select datepart(week , '2024/12/25');
select datepart(DAYOFYEAR , '2024/12/25');
select datepart(weekday , '2024/12/25');

select year('2024/12/25');
select month('2024/12/25');
select day('2024/12/25');

--datediff  الفرق بين تاريخين
select datediff(year , '2018/4/15', '2024/12/25')
select datediff(month , '2018/4/15', '2024/12/25')
select datediff(week , '2018/4/15', '2024/12/25')
select datediff(day , '2018/4/15', '2024/12/25')

--select dateadd
select dateadd(year,3,'2024/12/25')
select dateadd(month,3,'2024/12/25')
select dateadd(week,3,'2024/12/25')
select dateadd(day,3,'2024/12/25')

select dateadd(year,-3,'2024/12/25')
select dateadd(month,-3,'2024/12/25')
select dateadd(week,-3,'2024/12/25')
select dateadd(day,-3,'2024/12/25')

--2.1 Scalar- valued Function (return a single value)
create function CalculatePrice ( @cost decimal(18,2),@profitRatio decimal(18,2) , @shipping decimal(18,2)) returns decimal (18,2)
begin	
	return @cost+ @cost * @profitRatio + @shipping;
end




create function
GetDepartmentEmployees
(@depId int) 
returns table 
as 
return select * from Employees where DepartmentId= @depId;


select dbo.CalculatePrice(4000,0.25,100);
select * from GetDepartmentEmployees(1);


create procedure sp_Insert_Department @name nvarchar(50), @description nvarchar(max)
as 
begin 
insert into Departments (name ,Description) values (@name,@description);
end 

execute sp_Insert_Department 'TS' ,'Technical Support';
exec sp_Insert_Department 'TS','Technical Support';
sp_Insert_Department 'TS' ,'Technical Support';

create procedure sp_Select_Department @id  int 
as 
begin 
	select * from Departments where id =@id;
end 

execute sp_Select_Department 7
exec sp_Select_Department 7

CREATE  procedure sp_Update_Department @id int ,@name nvarchar(50), @description nvarchar(max)
as 
begin
	update Departments set name = @name ,description = @description where id =@id;
end

execute sp_Update_Department 5,'HR Deprt.','Human Resources Department';


create procedure sp_delete_Department @id int 
as 
begin 
	delete from Departments where id=@id;
end

exec sp_delete_Department 6;
select * from Departments;



































