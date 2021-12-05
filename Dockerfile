FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MicroMarketBackend.APIGateway/MicroMarketBackend.APIGateway.csproj", "MicroMarketBackend.APIGateway/"]
RUN dotnet restore "MicroMarketBackend.APIGateway/MicroMarketBackend.APIGateway.csproj"
COPY . .
WORKDIR "/src/MicroMarketBackend.APIGateway"
RUN dotnet build "MicroMarketBackend.APIGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroMarketBackend.APIGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroMarketBackend.APIGateway.dll"]
