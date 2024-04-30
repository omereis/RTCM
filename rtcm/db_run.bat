docker container rm -f rtcm-mysql
docker run --name rtcm-mysql -e MYSQL_ROOT_PASSWORD=secret -v mysql-data:/var/lib/mysql -d mysql
