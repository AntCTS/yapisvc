# yapisvc
YahooAPI Microservice

Microservice implementation on dotnetcore to get Stock values from Yahoo.

Run with "dotnet run", while in the path and in a linux box that has dotnetcore installed.

You should see something like below :

![image](https://github.com/AntCTS/yapisvc/blob/master/img.png?raw=true "yapi")

Call and test with Postman (chrome extension) like below :

![image](https://github.com/AntCTS/yapisvc/blob/master/postman.png?raw=true "yapi")

If you want to build a Docker image you can do so by using the following command in your Ubuntu linux distro :

<b>sudo docker build -t yapisvc .</b>


Process will take it's time and looks like below while running :

![image](https://github.com/AntCTS/yapisvc/blob/master/docker.png?raw=true "yapi")

Then after the containerization completes (all 10 steps), you should see something similar to :

![image](https://github.com/AntCTS/yapisvc/blob/master/docker2.png?raw=true "yapi")

Then you can run your instance like so :

<b>sudo docker run -d -p 5000:80 --name yapisvc yapisvc</b>
