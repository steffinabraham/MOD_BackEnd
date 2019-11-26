FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.APIGateway/MOD.APIGateway.csproj", "MOD.APIGateway/"]
RUN dotnet restore "MOD.APIGateway/MOD.APIGateway.csproj"
COPY . .
WORKDIR "/src/MOD.APIGateway"
RUN dotnet build "MOD.APIGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.APIGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.APIGateway.dll"]