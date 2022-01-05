FROM mcr.microsoft.com/dotnet/core/runtime:2.2.3 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2.105 AS build
WORKDIR /src
COPY ["Artillery.API/Artillery.API.csproj", "Artillery.API/"]
RUN dotnet restore "Artillery.API/Artillery.API.csproj"
COPY . .
WORKDIR "/src/Artillery.API"
RUN dotnet build "Artillery.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Artillery.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Artillery.API.dll"]
