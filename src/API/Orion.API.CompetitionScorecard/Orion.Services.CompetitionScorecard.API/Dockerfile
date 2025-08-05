FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
ENV ASPNETCORE_URLS=http://+:9007
USER $APP_UID
WORKDIR /app
EXPOSE 9007

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Services/Orion.Services.CompetitionScorecard/Orion.Services.CompetitionScorecard.API/Orion.Services.CompetitionScorecard.API.csproj", "src/Services/Orion.Services.CompetitionScorecard/Orion.Services.CompetitionScorecard.API/"]
COPY ["src/Core/Orion.Core.CompetitionScorecard/Orion.Core.CompetitionScorecard.csproj", "src/Core/Orion.Core.CompetitionScorecard/"]
RUN dotnet restore "src/Services/Orion.Services.CompetitionScorecard/Orion.Services.CompetitionScorecard.API/Orion.Services.CompetitionScorecard.API.csproj"
COPY . .
WORKDIR "/src/src/Services/Orion.Services.CompetitionScorecard/Orion.Services.CompetitionScorecard.API"
RUN dotnet build "./Orion.Services.CompetitionScorecard.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Orion.Services.CompetitionScorecard.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orion.Services.CompetitionScorecard.API.dll"]
