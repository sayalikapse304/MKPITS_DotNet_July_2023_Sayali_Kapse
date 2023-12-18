create table product2(product_id int,product_name varchar(20),model_year int,list_price int)
insert into product2 values(1,'laptop',2001,7000)
insert into product2 values(2,'computer',1999,8000)
insert into product2 values(5,'Tv',2009,70200)
insert into product2 values(3,'oven',1998,80000)
select product_id,product_name,model_year,list_price from product2
where model_year between 2000 and 2010
order by model_year desc;

   
