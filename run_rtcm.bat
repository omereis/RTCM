docker container rm -f rtcm
docker build --rm -f rtcm.dockerfile -t rtcm .
docker run -it -d -h rtcm --name rtcm -p 5005:5005 rtcm

docker exec -it rtcm bash