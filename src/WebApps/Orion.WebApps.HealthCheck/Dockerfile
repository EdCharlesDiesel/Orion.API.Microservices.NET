FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
ENV ASPNETCORE_URLS=http://+:5000
USER $APP_UID
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/WebApps/Orion.WebApps.HealthCheck/Orion.WebApps.HealthCheck.csproj", "src/WebApps/Orion.WebApps.HealthCheck/"]
RUN dotnet restore "src/WebApps/Orion.WebApps.HealthCheck/Orion.WebApps.HealthCheck.csproj"
COPY . .
WORKDIR "/src/src/WebApps/Orion.WebApps.HealthCheck"
RUN dotnet build "./Orion.WebApps.HealthCheck.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Orion.WebApps.HealthCheck.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orion.WebApps.HealthCheck.dll"]

