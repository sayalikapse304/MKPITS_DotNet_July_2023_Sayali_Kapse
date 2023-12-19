create table product4(product_id int,product_name varchar(20),model_year int,list_price int)
insert into product4 values(1,'laptop',2001,7000)
insert into product4 values(2,'computer',1999,8000)
insert into product4 values(5,'Tv',2009,70200)
insert into product4 values(3,'oven',1998,80000)
select product_id,product_name,model_year,list_price from product4
where list_price in (7000,8000)
order by list_price desc;

   
