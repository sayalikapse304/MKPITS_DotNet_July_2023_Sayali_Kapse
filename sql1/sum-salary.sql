create table employeinfo2(name varchar(30),occuption varchar (40),working_date date,working_hours int,salary int)
insert into employeinfo2 values('sayali','Manager','2023-12-09',8,80000)
insert into employeinfo2 values('pranali','HR','2023-12-09',9,30000)
insert into employeinfo2 values('abhi','Manager','2023-12-08',8,20000)
insert into employeinfo2 values('kamya','Peun','2023-12-07',7,10000)
insert into employeinfo2 values('aashu','clurk','2023-12-06',8,20000)
select * from employeinfo2

SELECT SUM(salary) AS "Total Salary" FROM employeinfo2;  