
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8083
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Services/StockAnalyzer/StockAnalyzer.API/Orion.Services.StockAnalyzer.API.csproj", "src/Services/StockAnalyzer/StockAnalyzer.API/"]
COPY ["src/Core/Orion.Core.StockAnalyzer/Orion.StockAnalyzer.Core.csproj", "src/Core/Orion.Core.StockAnalyzer/"]
RUN dotnet restore "./src/Services/StockAnalyzer/StockAnalyzer.API/./Orion.Services.StockAnalyzer.API.csproj"
COPY . .
WORKDIR "/src/src/Services/StockAnalyzer/StockAnalyzer.API"
RUN dotnet build "./Orion.Services.StockAnalyzer.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Orion.Services.StockAnalyzer.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orion.Services.StockAnalyzer.API.dll"]