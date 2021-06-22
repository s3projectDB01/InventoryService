FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app 
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY MenuApp.InventoryService/*.csproj ./MenuApp.InventoryService/
COPY MenuApp.InventoryService.EntityFramework/*.csproj ./MenuApp.InventoryService.EntityFramework/
COPY MenuApp.InventoryService.Logic/*.csproj ./MenuApp.InventoryService.Logic/
COPY IntegrationTests/*.csproj ./IntegrationTests/
#
RUN dotnet restore 
#
# copy everything else and build app
COPY MenuApp.InventoryService/. ./MenuApp.InventoryService/
COPY MenuApp.InventoryService.EntityFramework/. ./MenuApp.InventoryService.EntityFramework/
COPY MenuApp.InventoryService.Logic/. ./MenuApp.InventoryService.Logic/
COPY IntegrationTests/. ./IntegrationTests/
#
WORKDIR /app/MenuApp.InventoryService
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app 
#
COPY --from=build /app/MenuApp.InventoryService/out ./

EXPOSE 80
ENTRYPOINT ["dotnet", "MenuApp.InventoryService.dll"]