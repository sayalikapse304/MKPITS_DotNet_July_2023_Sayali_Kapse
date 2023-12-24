create table department1(dep_id int,dep_name varchar(30),manager_id int,location_id int)
insert into department1 values(11,'electronics',121,111)
insert into department1 values(12,'computer',131,222)
insert into department1 values(13,'electrical',141,333)
insert into department1 values(14,'mechanical',151,444)
insert into department1 values(15,'It',161,555)
select * from department1

create table employee111(empid int,first_name varchar(40),last_name varchar(40),email varchar(50),
                         phone_num bigint,hire_date date,job_id int,salary int,manager_id int,dep_id int)

insert into employee111 values(21,'sayali','kapse','sayli123',80800948,'2023-12-09',31,40000,121,11)
insert into employee111 values(22,'payal','wange','payal123',773848,'2023-12-08',32,50000,131,12)
insert into employee111 values(23,'achal','gire','achal123',46746535,'2023-12-07',33,60000,141,13)
insert into employee111 values(24,'asmi','sawan','asmi123',8366455,'2023-12-04',34,70000,151,14)
select *from employee111

create table location(location_id int,street_address varchar(80),postal_code int,city varchar(70),state_province varchar(60),
country_id varchar(50))
insert into location values(111,'nandanvan',44009,'nagpur','maharashtra',100)
insert into location values(222,'bhandeplot',44008,'bhandara','mp',200)
insert into location values(333,'bardi',44005,'lakhani','maharashtra',300)
select * from location
SELECT E.first_name,E.last_name, 
   D.dep_name, L.city, L.state_province
     FROM employee111 E 
      JOIN department1 D  
        ON E.dep_id = D.dep_id  
          JOIN location L
           ON D.location_id = L.location_id;


		  



 