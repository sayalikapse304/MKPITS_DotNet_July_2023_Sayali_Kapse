create table employeinfo11(name varchar(30),occuption varchar (40),working_date date,working_hours int,salary int)
insert into employeinfo11 values('sayali','Manager','2023-12-09',8,80000)
insert into employeinfo11 values('pranali','HR','2023-12-09',9,30000)
insert into employeinfo11 values('abhi','Manager','2023-12-08',8,20000)
insert into employeinfo11 values('kamya','Peun','2023-12-07',7,10000)
insert into employeinfo11 values('aashu','clurk','2023-12-06',8,20000)
select * from employeinfo11

SELECT occuption, AVG(working_hours) AS "Average Working Hours"   
    FROM employeinfo11 
     GROUP BY occuption;    