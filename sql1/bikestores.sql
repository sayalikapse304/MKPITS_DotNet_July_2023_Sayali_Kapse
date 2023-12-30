create table stores11(store_id int identity(1,1) primary key,store_name varchar(30)not null,phone bigint,
email varchar (80),street varchar(90),city varchar (40),state varchar(40),zip_code varchar(50));

insert into stores11 values('matoshri',8080094895,'sayali53@gmail.com','nandanvan','nagpur','maharashtra','440009')
insert into stores11 values('rambhadar',7775850872,'payal12@gmail.com','bhandeplot','nagpur','maharashtra','440033')
insert into stores11 values('kedar',9421715685,'santosh123@gmail.com','sadar','nagpur','maharashtra','44055')
insert into stores11 values('sapna',7066497262,'prany56@gmail.com','bardi','nagpur','maharashtra','440669')
insert into stores11 values('rangoli',9552169563,'nikhil323@gmail.com','hingna','nagpur','maharashtra','440449')
insert into stores11 values('surabhi',84120063535,'asmi99@gmail.com','sakhardhra','nagpur','maharashtra','440066')

select *from stores11


CREATE TABLE staffs 
	(staff_id int identity(1,1)  PRIMARY KEY,
	first_name VARCHAR (50) NOT NULL,
	last_name VARCHAR (50) NOT NULL,
	email VARCHAR (255) NOT NULL UNIQUE,
	phone bigint,
	active tinyint NOT NULL,
	store_id int NOT NULL,
	manager_id int ,
	constraint fk1
	FOREIGN KEY (store_id) 
    references stores (store_id));
	
	insert into staffs values('sayali','kapse','sayu123@gmail.com',9265242415,8,1,511)
	insert into staffs values('santosh','tale','santosh22@gmail.com',9265242415,4,2,123)
    insert into staffs values('achal','kale','achal55@gmail.com',9265242415,8,3,11)
    insert into staffs values('alpesh','mohite','alpesh99@gmail.com',9265242415,2,4,411)
    insert into staffs values('purva','yerne','purva33@gmail.com',9265242415,8,5,561)
    insert into staffs values('karshima','wange','karisham88@gmail.com',9265242415,3,6,411)
	select * from staffs
	

	create table categories(category_id int identity(1,1)primary key,category_name varchar(50));
	insert into categories values('car')
	insert into categories values('bike')
    insert into categories values('bycycal')
    insert into categories values('tractor')
    insert into categories values('truck')
    insert into categories values('baby_bycycal')
	select *from categories


	create table brands(brand_id int identity(1,1)primary key,brand_name varchar(50)not null);
	insert into brands values('swift')
	insert into brands values('herohonda')
	insert into brands values('ranger')
	insert into brands values('mahindra')
	insert into brands values('zyago')
	insert into brands values('sigma')
	select * from brands
	
	create table products333(product_id int identity(1,1)primary key,product_name varchar(50) not null,brand_id int not null,
	category_id int,model_year smallint,list_price int
	constraint fk222
	FOREIGN KEY (category_id) 
        REFERENCES categories (category_id) );
		insert into products333 values('cluch',1,1,2001,550)
		insert into products333 values('oil',3,3,2004,568)
        insert into products333 values('break',4,4,2006,560)
		select* from products333
		

		create table customers44(customer_id int identity(1,1) primary key,first_name varchar(30)not null,last_name varchar(30)not null,phone bigint,
email varchar (80),street varchar(90),city varchar (40),state varchar(40),zip_code varchar(50));

insert into customers44 values('vrushali','mohite',8080094895,'vrushali@gmail.com','digori','nagpur','maharashtra','440009')
insert into customers44 values('mayuri','kale',7775850872,'mayuri@gmail.com','rigna','nagpur','maharashtra','440033')
insert into customers44 values('mrunal','gajbiye',9421715685,'mrunal123@gmail.com','sadar','nagpur','maharashtra','44055')
insert into customers44 values('rita','ingole',7066497262,'rita@gmail.com','bardi','nagpur','maharashtra','440669')
insert into customers44 values('trishala','bhisikar',9552169563,'trishala@gmail.com','hingna','nagpur','maharashtra','440449')
insert into customers44 values('prachi','dahiwale',84120063535,'prachi@gmail.com','sakhardhra','nagpur','maharashtra','440066')

select *from customers44


CREATE TABLE orders2 (
	order_id INT IDENTITY (1, 1) PRIMARY KEY,
	customer_id INT,
	order_status varchar(50) NOT NULL,
	
	order_date DATE NOT NULL,
	required_date DATE NOT NULL,
	shipped_date DATE,
	store_id INT NOT NULL,
	staff_id INT NOT NULL,
	FOREIGN KEY (customer_id) 
        REFERENCES customers44 (customer_id), 
       
	FOREIGN KEY (store_id) 
        REFERENCES stores (store_id) ,
        
	FOREIGN KEY (staff_id) 
        REFERENCES staffs (staff_id) 
       
);
insert into orders2 values(1,'pending','2023-12-9','2023-12-12','2023-12-14',1,1)
insert into orders2 values(2,'processing','2023-12-9','2023-12-12','2023-12-14',2,2)
insert into orders2 values(3,'completed','2023-12-9','2023-12-12','2023-12-14',3,3)
select *from orders2


CREATE TABLE order_items(
	order_id INT,
	item_id INT,
	product_id INT NOT NULL,
	quantity INT NOT NULL,
	list_price int NOT NULL,
	discount int NOT NULL,
	PRIMARY KEY (order_id, item_id),
	FOREIGN KEY (order_id) 
        REFERENCES orders2 (order_id) ,
        
	FOREIGN KEY (product_id) 
        REFERENCES products33 (product_id) );
		insert into order_items values(1,1,1,2,550000,500)
		insert into order_items values(2,2,2,1,567000,500)
		select *from order_items
		
       
	   CREATE TABLE stocks (
	store_id INT,
	product_id INT,
	quantity INT,
	PRIMARY KEY (store_id, product_id),
	FOREIGN KEY (store_id) 
        REFERENCES stores (store_id) ,
        
	FOREIGN KEY (product_id) 
        REFERENCES products33 (product_id) );
		insert into stocks values(1,1,2)
		insert into stocks values(2,2,1)
		select *from stocks
		select *from stores11
		select *from staffs 
		select *from categories
		select * from brands
		select* from products333
       select *from customers44
	   select *from orders2
	   select *from order_items