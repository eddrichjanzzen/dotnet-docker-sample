#Get the image from microsoft
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src

#Copy the C# project file
COPY SimpleTodo.csproj .


RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0


#We need to add this for so the app will know to use localhost by default
#ENV ASPNETCORE_URLS=http://+:5000


#run the simple todo dll
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "SimpleTodo.dll"]