create table products4(product_id int identity primary key,product_name varchar(40)Not null,unit_price dec(10,2) constraint positive_price check(unit_price>0))
insert into products4 values('mouse',120)
insert into products4 values('camera',990)

select * from products4
drop table products4