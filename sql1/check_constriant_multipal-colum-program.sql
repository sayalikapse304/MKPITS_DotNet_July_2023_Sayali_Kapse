CREATE TABLE products11(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2),
    discounted_price DEC(10,2),
    CHECK(unit_price > 0),
    CHECK(discounted_price > 0 AND discounted_price < unit_price))

	insert into products11 values('mouse',120,20)
insert into products11 values('mouse',0,0)
insert into products11 values('mouse',120,220)
select * from products11
drop table products11