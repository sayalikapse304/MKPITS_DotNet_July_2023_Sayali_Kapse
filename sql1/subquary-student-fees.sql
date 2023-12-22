create table student12(rno int,name varchar(40),email varchar(80),city varchar(40),courseid int)
insert into student12 values(11,'sayali','sayali123','nagpur',111)
insert into student12 values(12,'monal','monal143','pune',222)
insert into student12 values(13,'sonal','sonal123','nagpur',333)
insert into student12 values(14,'aashu','aashu123','bhopal',444)
insert into student12 values(15,'neham','neham123','nagpur',555)
insert into student12 values(16,'purva','purva123','nagpur',666)
insert into student12 values(17,'pragati','pragati123','pune',777)

select *from student12

create table fees12(feesid int,rno int,feesdate date,amount int,courseid int)
insert into fees12 values(1,11,'2023-12-09',5000,111)
insert into fees12  values(2,12,'2023-12-07',6000,222)
insert into fees12  values(3,13,'2023-12-06',8000,333)
insert into fees12  values(4,14,'2023-12-08',5000,444)
insert into fees12  values(5,15,'2023-12-09',8000,555)
insert into fees12 values(6,16,'2023-12-09',4000,666)
insert into fees12 values(7,17,'2023-12-04',5000,777)
select * from fees12

select feesid,rno,feesdate,amount,courseid
from fees12
where courseid in
(select courseid from student12
where city='nagpur')

select feesid,rno,feesdate,amount,courseid
from fees12
where courseid in
(select courseid from student12
where city='bhopal')

select feesid,rno,feesdate,amount,courseid
from fees12
where courseid in
(select courseid from student12
where city='pune')




drop table student12
drop table fees12


