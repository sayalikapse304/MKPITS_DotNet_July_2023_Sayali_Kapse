CREATE TABLE person_skills (
    id INT IDENTITY PRIMARY KEY,
    person_id int,
    skill_id int,
    updated_at DATETIME,
    UNIQUE (person_id, skill_id));

insert into person_skills values(111,10,'2021-12-12')
insert into person_skills values(115,100,'2021-12-12')
insert into person_skills values(112,10,'2021-12-12')
insert into person_skills values(118,10,'2021-12-12')
insert into person_skills values(118,12,'2021-12-12')
select * from person_skills
drop table person_skills