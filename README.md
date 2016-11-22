# Server.Interface
This is a pre-game api server, made in .NET CORE and API v2

## Requirements
[.NET CORE](https://www.microsoft.com/net/core)

### Additional info

* I am using Visual Studio 2015 and .net core 1.0.1

* This is one of two parts. The server and the client. To get the client follow the link below.
[Client.Interface](https://github.com/cynical89/Client.Interface)

##Deployment (linux)
To deploy with windows use Visual Studio 2015

* Clone the repository
```
git clone https://github.com/cynical89/Server.Interface.git
```

* Install npm, bower, and gulp
```
sudo apt-get install npm
sudo npm install bower -g
sudo npm install gulp -g
```

* Restore dependencies and publish for both projects in the soluction

from inside src/Server.Identity & src/Server.Interface
```
dotnet restore
dotnet publish
```

* Run the solutions
from inside src/Server.Identify
```
screen -S identity
dotnet run
```
Ctrl-A and Ctrl-D to detach the screen and leave the identity server running

from inside src/Server.Interface
```
screen -S interface
dotnet run
```
Ctrl-A and Ctrl-D to detach the screen and leave the identity server running

* Install nginx
```
sudo apt-install nginx
sudo service nginx start
```

* Modify nginx configuration
```
sudo vi /etc/nginx/sites-available/default
```
After it opens, replace the file with the following code
```bash
server {
    listen 80;
    location / {
        proxy_pass http://localhost:5001;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection keep-alive;
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
    }
}
```

* Test nginx config and restart service
```
sudo nginx -t
sudo nginx -s reload
```

* Enjoy!
