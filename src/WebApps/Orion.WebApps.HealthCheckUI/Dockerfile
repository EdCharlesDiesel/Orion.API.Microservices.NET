FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/WebApps/Orion.WebApps.HealthCheckUI/Orion.WebApps.HealthCheckUI.csproj", "src/WebApps/Orion.WebApps.HealthCheckUI/"]
RUN dotnet restore "src/WebApps/Orion.WebApps.HealthCheckUI/Orion.WebApps.HealthCheckUI.csproj"
COPY . .
WORKDIR "/src/src/WebApps/Orion.WebApps.HealthCheckUI"
RUN dotnet build "./Orion.WebApps.HealthCheckUI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Orion.WebApps.HealthCheckUI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orion.WebApps.HealthCheckUI.dll"]
