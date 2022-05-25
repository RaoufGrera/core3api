FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["core3api/core3api.csproj", "core3api/"]
COPY ["SystemData/SystemData.csproj", "SystemData/"]

RUN dotnet restore "core3api/core3api.csproj"
COPY . .
WORKDIR "/src/core3api"
RUN dotnet build "core3api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "core3api.csproj" -c Release -o /app/publish

FROM node AS node-builder
WORKDIR /node
COPY ["core3api/dist", "node/"]


FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
EXPOSE 80
#RUN mkdir /app/wwwroot
#COPY --from=node-builder /node/build ./wwwroot
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "core3api.dll"]

