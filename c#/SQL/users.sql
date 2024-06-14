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
	first		varchar(50),
	last		varchar(50),
	is_active	tinyint,
	username	varchar(50) not null unique,
	passwd		varchar(100),
	foreign key (level_id) references user_level(level_id) on update cascade on delete set null
);
/*--------------------------------*/
insert into user_level(level_id,level_name) values (1,'Tester'),(2,'Manager'),(3,'Administrator');

insert into users(user_id,level_id,first,last,username,passwd) values (100,3,'Rotem','SQA','admin',1,'admin_password');
delete from users;
insert into users(user_id,level_id,first,last,is_active,username,passwd) values 
					(100,3,'Rotem','SQA',1,'admin','admin_password'),
					(101,1,'Asi','Sharabi',0,'asis','asis');
alter table users modify is_active integer;

drop view vUsers;
create view vUsers (
	user_id,
	level_id,
	level_name,
	first,
	last,
	is_active,
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
			is_active,
			username,
			passwd
		from
			users,user_level
		where
			users.level_id = user_level.level_id
union
		select
			user_id,
			'' as 'level_id',
			'' as 'level_name',
			first,
			last,
			is_active,
			username,
			passwd
		from
			users
		where
			users.level_id is null;

select * from user_level;

insert into users(user_id,level_id,first,last,is_active,username,passwd) values 
					(102,3,'Adel','Vanunu',1,'adelv','adel');
select * from users;
select * from vUsers;
select * from vUsers where user_id=100;

alter table users drop stam;

update users set is_active=1 where user_id=102;
update users set stam=1  where user_id != 102;