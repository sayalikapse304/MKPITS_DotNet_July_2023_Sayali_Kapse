create table product87112(product_id int,product_name varchar(50),brand_id int,category_id int,model_year int,list_price int)
insert into product87112 values(11,'laptop',21,31,2023,80000)
insert into product87112 values(12,'computer',22,32,2023,30000)
insert into product87112 values(13,'mouse',23,33,2023,60000)
insert into product87112 values(14,'keyboard',24,34,2023,20000)
insert into product87112 values(15,'mobail',25,35,2023,10000)
select * from product87112
drop table product87112
DECLARE
@product_name varchar(50), @list_price int

DECLARE cursor_product321 CURSOR
FOR SELECT 
        product_name, 
        list_price
    FROM 
        product87112
		where product_name='mouse'

		open cursor_product321

		FETCH NEXT FROM cursor_product321 INTO 
    @product_name, 
    @list_price;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @product_name + CAST(@list_price AS varchar);
        FETCH NEXT FROM cursor_product321 INTO 
            @product_name,
            @list_price;
    END;

	close cursor_product11;

	DEALLOCATE cursor_product11;


