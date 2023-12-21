create table student24(id int primary key identity,admission_no int,first_name varchar(40)not null,last_name varchar(50) not null,age int,city varchar(70)); 
create table fee(admission_no int,course varchar(80) not null,amount_paid int);

insert into student24 values(2233,'sayali','kapse',23,'Nagpur')
insert into student24 values(2234,'payal','pawar',24,'pune')
insert into student24 values(2273,'Asmi','khope',26,'Nagpur')
insert into student24 values(7233,'Achal;','rangari',28,'Mumbai')
select *from student24

insert into fee values(2233,'java',20000)
insert into fee values(2234,'android',6600) 
insert into fee values(2273,'php',5550) 
insert into fee values(7233,'dotnet',8880)
select* from fee
 SELECT student24.admission_no, student24.first_name, student24.last_name, Fee.course, Fee.amount_paid  
    FROM student24  
    INNER JOIN Fee  
    ON student24.admission_no = Fee.admission_no;
drop table fee
drop table student24