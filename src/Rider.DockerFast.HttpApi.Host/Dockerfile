#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/Rider.DockerFast.HttpApi.Host/Rider.DockerFast.HttpApi.Host.csproj", "src/Rider.DockerFast.HttpApi.Host/"]
COPY ["src/Rider.DockerFast.HttpApi/Rider.DockerFast.HttpApi.csproj", "src/Rider.DockerFast.HttpApi/"]
COPY ["src/Rider.DockerFast.Application.Contracts/Rider.DockerFast.Application.Contracts.csproj", "src/Rider.DockerFast.Application.Contracts/"]
COPY ["src/Rider.DockerFast.Domain.Shared/Rider.DockerFast.Domain.Shared.csproj", "src/Rider.DockerFast.Domain.Shared/"]
COPY ["src/Rider.DockerFast.EntityFrameworkCore/Rider.DockerFast.EntityFrameworkCore.csproj", "src/Rider.DockerFast.EntityFrameworkCore/"]
COPY ["src/Rider.DockerFast.Domain/Rider.DockerFast.Domain.csproj", "src/Rider.DockerFast.Domain/"]
COPY ["src/Rider.DockerFast.Application/Rider.DockerFast.Application.csproj", "src/Rider.DockerFast.Application/"]
RUN dotnet restore "src/Rider.DockerFast.HttpApi.Host/Rider.DockerFast.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/Rider.DockerFast.HttpApi.Host"
RUN dotnet build "Rider.DockerFast.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rider.DockerFast.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rider.DockerFast.HttpApi.Host.dll"]