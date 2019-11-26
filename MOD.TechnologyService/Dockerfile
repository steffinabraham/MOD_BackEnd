FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.TechnologyService/MOD.TechnologyService.csproj", "MOD.TechnologyService/"]
RUN dotnet restore "MOD.TechnologyService/MOD.TechnologyService.csproj"
COPY . .
WORKDIR "/src/MOD.TechnologyService"
RUN dotnet build "MOD.TechnologyService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.TechnologyService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.TechnologyService.dll"]