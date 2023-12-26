create table employee321(emp_id int identity primary key,first_name varchar(40),last_name varchar(40),email varchar(40),phone bigint,hire_date date,
                        manager_id int,salary int,department_id int)

create table EmpLog11(empid int not null,operation nvarchar(50),updatedDate datetime not null)

create trigger t1321
on employee321
after update as
insert into EmpLog11( empid,operation,updatedDate)
select emp_id,'update',getdate()from deleted;

insert into employee321 values('sayali','kapse','sayali123',9764535523,'2023-12-09',21,50000,31)
insert into employee321 values('payal','parmar','payal123',544352623,'2023-12-05',22,80000,32)
update employee321 set first_name='amitabh' where emp_id=2
select * from employee321
select * from EmpLog11
drop table employee321
drop table EmpLog11