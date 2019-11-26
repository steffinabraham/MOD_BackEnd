FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.AuthenticateService/MOD.AuthenticateService.csproj", "MOD.AuthenticateService/"]
RUN dotnet restore "MOD.AuthenticateService/MOD.AuthenticateService.csproj"
COPY . .
WORKDIR "/src/MOD.AuthenticateService"
RUN dotnet build "MOD.AuthenticateService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.AuthenticateService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.AuthenticateService.dll"]