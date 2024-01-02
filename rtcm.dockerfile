FROM ubuntu:18.04

# Update the apt-get index and then install project dependencies
RUN apt-get update && apt-get install -y man vim
#RUN apt-get update && apt-get install -y man vim git tree
#RUN apt install -y mysql-client
RUN apt update
RUN apt update
RUN apt install -y software-properties-common
RUN add-apt-repository -y ppa:deadsnakes/ppa
RUN apt install -y python3.7
RUN ln -s /usr/bin/python3.7 /usr/bin/python
RUN apt install -y python3-distutils
RUN apt install -y curl
RUN curl -sSL https://bootstrap.pypa.io/get-pip.py -o /tmp/get-pip.py
RUN python /tmp/get-pip.py
RUN python -m pip install --upgrade pip
RUN pip install flask
RUN pip install Flask-session

ENV HOME=/home/oe

WORKDIR /home/oe/rtcm
#WORKDIR /home/oe/cpp/rp_server
EXPOSE 5010

COPY ./ $HOME
WORKDIR $HOME/rtcm