FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Services/Orion.Services.Catalog/Orion.Services.Catalog.API/Orion.Services.Catalog.API.csproj", "src/Services/Orion.Services.Catalog/Orion.Services.Catalog.API/"]
COPY ["src/Core/Orion.Core.Basket/Orion.Core.Basket.csproj", "src/Core/Orion.Core.Basket/"]
COPY ["src/Core/Orion.Core.Order/Orion.Core.Order.csproj", "src/Core/Orion.Core.Order/"]
COPY ["src/Core/Orion.Core.Catalog/Orion.Core.Catalog.csproj", "src/Core/Orion.Core.Catalog/"]
COPY ["src/Core/Orion.Core.TradingEconomics/Orion.Core.TradingEconomics.csproj", "src/Core/Orion.Core.TradingEconomics/"]
COPY ["src/Core/Orion.Core.UserProfile/Orion.Core.UserProfile.csproj", "src/Core/Orion.Core.UserProfile/"]
RUN dotnet restore "src/Services/Orion.Services.Catalog/Orion.Services.Catalog.API/Orion.Services.Catalog.API.csproj"
COPY . .
WORKDIR "/src/src/Services/Orion.Services.Catalog/Orion.Services.Catalog.API"
RUN dotnet build "./Orion.Services.Catalog.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Orion.Services.Catalog.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orion.Services.Catalog.API.dll"]
