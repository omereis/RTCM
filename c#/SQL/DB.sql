drop database rtcm;
select * from mysql.user;
delete from mysql.user where user='RotemRadAdmin';
drop user 'RotemRadAdmin'@'localhost';
drop user 'RotemRadAdmin'@'%';

CREATE USER 'RotemRadAdmin'@'localhost' IDENTIFIED BY 'RotemRad2024';
CREATE USER 'RotemRadAdmin'@'%' IDENTIFIED BY 'RotemRad2024';

create database RTCM;

GRANT ALL ON `rtcm`.* TO 'RotemRadAdmin'@'%' WITH GRANT OPTION; 
GRANT ALL ON `rtcm`.* TO 'RotemRadAdmin'@'localhost' WITH GRANT OPTION; 

SHOW GRANTS FOR 'RotemRadAdmin'@'%';
SHOW GRANTS FOR 'RotemRadAdmin'@'localhost';
 
 
