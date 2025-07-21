FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/ApiGateways/OcelotApiGw/Orion.OcelotApiGw.csproj", "src/ApiGateways/OcelotApiGw/"]
COPY ["src/Infrastructure/Common.Logging/Orion.Common.Logging.csproj", "src/Infrastructure/Common.Logging/"]
RUN dotnet restore "src/ApiGateways/OcelotApiGw/Orion.OcelotApiGw.csproj"
COPY . .
WORKDIR "/src/src/ApiGateways/OcelotApiGw"
RUN dotnet build "./Orion.OcelotApiGw.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Orion.OcelotApiGw.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orion.OcelotApiGw.dll"]
