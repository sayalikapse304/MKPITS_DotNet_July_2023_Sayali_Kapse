CREATE TABLE persons11 (
    person_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    email VARCHAR(255),
    phone VARCHAR(20),
);  
insert into persons11 values('sayali','kapse','sayu12','12233')
insert into persons11 values('payal','kapse','sayu1233','13333')
insert into persons11 values('asmi','shendre','sayu1222','14433')
select *from persons11

ALTER TABLE persons11
ADD CONSTRAINT unique_email1 UNIQUE(email,phone);
drop table persons11