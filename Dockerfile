FROM microsoft/dotnet:latest

MAINTAINER Dharmendra Singh

COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build", "./src"]


EXPOSE 5000/tcp

CMD ["dotnet", "run","-p","./src/","--server.urls", "http://*:5000"]
