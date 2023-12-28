create table teacher_detail22 (teacher_id int primary key,teacher_age
int)
create table teacher_subject1(teacher_id int,subject varchar(20),
constraint t1331 foreign key(teacher_id) references teacher_detail22
(teacher_id))
insert into teacher_subject1 values(111,'chemistry')
insert into teacher_detail22 values(111,30)
insert into teacher_subject1 values(111,'chemistry')

select * from teacher_subject1
select * from teacher_detail22

drop table teacher_subject1
drop table  teacher_detail22