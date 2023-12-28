create table product87(product_id int,product_name varchar(50),brand_id int,category_id int,model_year int,list_price int)
insert into product87 values(11,'laptop',21,31,2023,80000)
insert into product87 values(12,'computer',22,32,2023,30000)
insert into product87 values(13,'mouse',23,33,2023,60000)
insert into product87 values(14,'keyboard',24,34,2023,20000)
insert into product87 values(15,'mobail',25,35,2023,10000)
select * from product87

DECLARE
@product_name1 varchar(50), @list_price1 int

DECLARE cursor_product CURSOR
FOR SELECT 
        product_name, 
        list_price
    FROM 
        product87;

		open cursor_product

		FETCH NEXT FROM cursor_product INTO 
    @product_name1, 
    @list_price1;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @product_name1 + CAST(@list_price1 AS varchar);
        FETCH NEXT FROM cursor_product INTO 
            @product_name1, 
            @list_price1;
    END;

	close cursor_product;

	DEALLOCATE cursor_product;


