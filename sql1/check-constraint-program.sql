create table products3(product_id int identity primary key,product_name varchar(40)Not null,unit_price dec(10,2)check(unit_price>0))
insert into products3 values('mouse',120)
insert into products3 values('camera',990)

select * from products3 
drop table products3