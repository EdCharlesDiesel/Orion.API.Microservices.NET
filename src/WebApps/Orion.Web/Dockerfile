FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8083


FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/WebApps/Orion.Web/Orion.Web.csproj", "src/WebApps/Orion.Web/"]
COPY ["src/Core/Orion.Core.StockAnalyzer/Orion.StockAnalyzer.Core.csproj", "src/Core/Orion.Core.StockAnalyzer/"]
RUN dotnet restore "src/WebApps/Orion.Web/Orion.Web.csproj"
COPY . .
WORKDIR "/src/src/WebApps/Orion.Web"
RUN dotnet build "./Orion.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Orion.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orion.Web.dll"]
