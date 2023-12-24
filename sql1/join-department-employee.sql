create table department(dep_id int,dep_name varchar(30),manager_id int,location_id int)
insert into department values(11,'electronics',121,111)
insert into department values(12,'computer',131,222)
insert into department values(13,'electrical',141,333)
insert into department values(14,'mechanical',151,444)
insert into department values(15,'It',161,555)
select * from department

create table employee11(empid int,first_name varchar(40),last_name varchar(40),email varchar(50),
                         phone_num bigint,hire_date date,job_id int,salary int,manager_id int,dep_id int)

insert into employee11 values(21,'sayali','kapse','sayli123',80800948,'2023-12-09',31,40000,121,11)
insert into employee11 values(22,'payal','wange','payal123',773848,'2023-12-08',32,50000,131,12)
insert into employee11 values(23,'achal','gire','achal123',46746535,'2023-12-07',33,60000,141,13)
insert into employee11 values(24,'asmi','sawan','asmi123',8366455,'2023-12-04',34,70000,151,14)
select *from employee11
drop table employee11

SELECT E.first_name , E.last_name , 
       E.dep_id , D.dep_name 
        FROM employee11 E 
         JOIN department D 
          ON E.dep_id = D.dep_id;










 