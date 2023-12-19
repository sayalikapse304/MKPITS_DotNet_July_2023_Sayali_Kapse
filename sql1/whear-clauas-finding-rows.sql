create table student7(first_name varchar(20),city varchar(20))
insert into student7 values('sayali','nagpur')
insert into student7 values('payal','bhandar')
insert into student7 values('deep','nashik')
insert into student7 values('santosh','nagardhan')
insert into student7 values('pavan','ramtek')
select * from student7 where first_name like '%li'

   select * from student7 where city like 'bh%'
   drop table student7