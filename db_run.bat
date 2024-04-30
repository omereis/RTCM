docker container rm -f mysql1
docker run --name mysql1 -e MYSQL_ROOT_PASSWORD=secret -d mysql

