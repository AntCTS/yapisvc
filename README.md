# yapisvc
YahooAPI Microservice

Microservice implementation on dotnetcore to get Stock values from Yahoo.

Run with "dotnet run", while in the path and in a linux box that has dotnetcore installed.

You should see something like below :

![image](https://github.com/AntCTS/yapisvc/blob/master/img.png?raw=true "yapi")

Call and test with Postman (chrome extension) like below :

![image](https://github.com/AntCTS/yapisvc/blob/master/postman.png?raw=true "yapi")

If you want to build a Docker image you can do so by using the following command in your Ubuntu linux distro :

sudo docker build -t yapisvc .
