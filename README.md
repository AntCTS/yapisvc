# yapisvc
YahooAPI Microservice

Development Enviroment :<br> 
- Linux Mint 18.04 (latest as of today)<br>
- dotnet core 2.1 <br>
- Docker (edge build)
- YahooAPI pkg

This is a containerized microservice implementation on dotnetcore to get Stock values from Yahoo.
To run in linux (or any other OS supporting dotnetcore) use "dotnet run", while in the path of the project.
You should see something like below :

![image](https://github.com/AntCTS/yapisvc/blob/master/img.png?raw=true "yapi")

You can test with Postman (chrome extension) like below :

![image](https://github.com/AntCTS/yapisvc/blob/master/postman.png?raw=true "yapi")

Containerization is easy as a script is provided.<br>
If you want to build a Docker image you can do so by using the following command in your linux distro :

<b>sudo docker build -t yapisvc .</b>

Process will take it's time and looks like below while running :

![image](https://github.com/AntCTS/yapisvc/blob/master/docker.png?raw=true "yapi")

Then after the containerization completes (all 10 steps), you should see something similar to :

![image](https://github.com/AntCTS/yapisvc/blob/master/docker2.png?raw=true "yapi")

Now, because the Docker instance will not manage the network bindings, if you want your service bound to the same port 
you can run your instance like so :

<b>sudo docker run -p 5000:5000 yapisvc</b>

To stop the Docker instance just issue : <b>sudo docker stop yapisvc</b>. <br>
And to completely remove it, issue : <b>sudo docker rm yapisvc</b>

Of course you can run multiple instances in different containers. <br>
Below, final screenshot hitting the microservice from outside the Linux box, and using the Docker instance : <br>

![image](https://github.com/AntCTS/yapisvc/blob/master/docker3.png?raw=true "yapi")
