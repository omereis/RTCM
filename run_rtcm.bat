docker container rm -f rtcm
docker build --rm -f rtcm.dockerfile -t rtcm .
docker run -it -d -h rtcm -h mysql1 --name rtcm -p 5010:5010 rtcm

docker exec -it rtcm bash