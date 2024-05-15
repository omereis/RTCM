/*
drop view vUsers;
drop table user_level;
drop table users;
*/

create table if not exists user_level (
	level_id	integer not null primary key,
	level_name	varchar(25)
);
/*--------------------------------*/
drop table  users;
create table if not exists users (
	user_id	integer not null primary key,
	level_id	integer,
	first	varchar(50),
	last	varchar(50),
	username	varchar(50) not null unique,
	passwd	varchar(100),
	foreign key (level_id) references user_level(level_id) on update cascade on delete set null
);
/*--------------------------------*/
insert into user_level(level_id,level_name) values (1,'Tester'),(2,'Manager'),(3,'Administrator');

insert into users(user_id,level_id,first,last,username,passwd) values (100,3,'Rotem','SQA','admin','admin_password');
insert into users(user_id,first,last,username,passwd) values (101,'Asi','Sharabi','asis','asis');

drop view vUsers;
create view vUsers (
	user_id,
	level_id,
	level_name,
	first,
	last,
	username,
	passwd
	)
	as
		select
			user_id,
			user_level.level_id,
			level_name,
			first,
			last,
			username,
			passwd
		from
			users,user_level
		where
			users.level_id = user_level.level_id
union
		select
			user_id,
			null as 'level_id',
			null as 'level_name',
			first,
			last,
			username,
			passwd
		from
			users
		where
			users.level_id is null;

select * from user_level;

select * from users;
select * from vUsers;