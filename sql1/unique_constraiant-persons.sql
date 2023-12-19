CREATE TABLE persons(
    person_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE);

insert into persons values('amit','kumar','a@gmail.com')
insert into persons values('amit','bhai','saayali@gmail.com')
select *from persons
drop table persons