CREATE TABLE persons9 (
    person_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    email VARCHAR(255),
    CONSTRAINT unique_email UNIQUE(email)
);
insert into persons9 values('sayali','kapse','sayali123')
insert into persons9 values('payal','sarode','payal12')
insert into persons9 values('samir','barai','samir123')
select *from persons9