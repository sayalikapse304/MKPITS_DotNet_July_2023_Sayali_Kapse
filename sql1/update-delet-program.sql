
create table product23(price int,productname varchar(20))
insert into product23 values(200,'desktop')
insert into product23 values(500,'keyboard')
insert into product23 values(400,'mouse')


update product23 set price=10000
where productname='desktop'

update product23 set price=300
where productname='keyboard' 

delete  from product23 
where productname='mouse'

select * from product23
drop table product23

