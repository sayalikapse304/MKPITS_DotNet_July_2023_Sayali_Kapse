create table student122(rno int,name varchar(40),email varchar(80),city varchar(40),courseid int)
insert into student122 values(11,'sayali','sayali123','nagpur',111)
insert into student122 values(12,'monal','monal143','pune',222)
insert into student122 values(13,'sonal','sonal123','nagpur',333)
insert into student122 values(14,'aashu','aashu123','bhopal',444)
insert into student122 values(15,'neham','neham123','nagpur',555)
insert into student122 values(16,'purva','purva123','nagpur',666)
insert into student122 values(17,'pragati','pragati123','pune',777)

select *from student122

create table course(courseid int,course_name varchar(30),fees int,duration varchar(60))
insert into course values(111,'java',60000,'3-month')
insert into course  values(222,'php',6000,'2-month')
insert into course  values(333,'java',8000,'3-month')
insert into course  values(444,'dotnet',5000,'3-month')
insert into course  values(555,'dotnet',8000,'2-month')
insert into course values(666,'dotnet',4000,'3-month')
insert into course values(777,'dotnet',5000,'2-month')
select * from course

select courseid,course_name,fees,duration
from course
where courseid in
(select courseid from student122
where course_name='java')


select courseid,course_name,fees,duration
from course
where courseid in
(select courseid from student122
where course_name='php')


select courseid,course_name,fees,duration
from course
where courseid in
(select courseid from student122
where course_name='dotnet')





