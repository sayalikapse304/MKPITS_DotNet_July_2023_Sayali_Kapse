create table student5(rno int primary key,marks int check(marks>0))
insert into student5 values(1,0)
insert into student5 values(1,50)
select *from student5
alter table student5 add constraint per check(per>0)

drop table student5