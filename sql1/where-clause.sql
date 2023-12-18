 create table students(rno int,first_name varchar(20),city varchar (20))
 insert into students values(22,'sayali','naghbhid')
 insert into students values(23,'payal','mumbai')
 insert into students values(24,'prany','nagpur')
 select *from students
 select * from students where rno=1
select * from students where rno>4
select * from students where first_name='prany'
select * from students where city='nagpur'
drop table students