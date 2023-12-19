create table products6(product_id int identity primary key,product_name varchar(40) not null,unit_price dec(10,3)check(unit_price>0),discount_price dec(10,2) check(discount_price>0),check(discount_price<unit_price))
insert into products6 values('mouse',120,20)
insert into products6 values('mouse',0,0)
insert into products6 values('mouse',120,220)
select * from products6