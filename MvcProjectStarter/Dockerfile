#The FROM command tells Docker to pull down the image tagged 3.1 from the specified repository. 
FROM mcr.microsoft.com/dotnet/core/runtime:3.1

#tells Docker to copy the publish/ directory on your computer to a new app/ directory inside the container.
COPY bin/Release/netcoreapp3.1/publish/ app/

# tells Docker to configure the container to run as an executable.
ENTRYPOINT ["dotnet", "app/MvcProjectStarter.dll"]