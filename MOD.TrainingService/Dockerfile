FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.TrainingService/MOD.TrainingService.csproj", "MOD.TrainingService/"]
RUN dotnet restore "MOD.TrainingService/MOD.TrainingService.csproj"
COPY . .
WORKDIR "/src/MOD.TrainingService"
RUN dotnet build "MOD.TrainingService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.TrainingService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.TrainingService.dll"]