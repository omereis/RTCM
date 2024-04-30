CREATE USER 'omereis'@'%' IDENTIFIED BY 'admin';
GRANT ALL PRIVILEGES ON *.* TO 'omereis'@'%';

docker run --name=mysql1 -d mydb

