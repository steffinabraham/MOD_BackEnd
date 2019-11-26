FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.UserService/MOD.UserService.csproj", "MOD.UserService/"]
RUN dotnet restore "MOD.UserService/MOD.UserService.csproj"
COPY . .
WORKDIR "/src/MOD.UserService"
RUN dotnet build "MOD.UserService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.UserService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.UserService.dll"]