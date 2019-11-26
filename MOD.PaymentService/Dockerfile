FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.PaymentService/MOD.PaymentService.csproj", "MOD.PaymentService/"]
RUN dotnet restore "MOD.PaymentService/MOD.PaymentService.csproj"
COPY . .
WORKDIR "/src/MOD.PaymentService"
RUN dotnet build "MOD.PaymentService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.PaymentService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.PaymentService.dll"]