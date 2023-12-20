create table ord1(order_id int identity primary key,order_Date date,customer_id int)
create table orders_Details1(order_id int,product_name varchar(20),quantity int,
                            constraint fk3 foreign key(order_id)references ord(order_id))

							insert into ord1 values('2023-02-09',123)
							insert into ord1 values('2023-03-03',123)

							insert into orders_Details1 values(1,'mouse',2)
							insert into orders_Details1 values(2,'laqptop',1)

							select * from ord1
							select *from orders_Details1
						drop table ord1
						drop table orders_Details1