
#  Setup an Angular ASP.NET Core WebAPI using Docker

# Prerequisites
### Source Control: *git*
- Git
```
$ git --version
git version 2.14.3 (Apple Git-98)
```

### Backend: *dotnet cli* , *docker*, *docker-compose*

- dotnet cli
```
$ dotnet --version
3.0.100
```

-  docker
```
$ docker --version
Docker version 19.03.2, build 6a30dfc
```

-  docker-compose
```
$ docker-compose --version
docker-compose version 1.24.1, build 4667896b
```

 - dotnet-aspnet-codegenerator

```
$ dotnet tool install -g dotnet-aspnet-codegenerator
``` 

### Generate a simple empty api scaffold

```
$ dotnet aspnet-codegenerator controller -name <name of controller> -async -api --readWriteActions -outDir Controllers
```

### Initial Migration command
```
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```ker version 19.03.2, build 6a30dfc
```

-  docker-compose
```
$ docker-compose --version
docker-compose version 1.24.1, build 4667896b
```

 - dotnet-aspnet-codegenerator

```
$ dotnet tool install -g dotnet-aspnet-codegenerator
``` 

### Add the ff Project Dependencies 
```
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer
$ dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### Generate a simple empty api scaffold

```
$ dotnet aspnet-codegenerator controller -name <name of controller> -async -api --readWriteActions -outDir Controllers
```

### Initial Migration command
```
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```