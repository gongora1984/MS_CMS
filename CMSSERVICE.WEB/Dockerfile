#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CMSSERVICE.WEB/CMSSERVICE.WEB.csproj", "CMSSERVICE.WEB/"]
COPY ["CMSSERVICE.APPLICATION/CMSSERVICE.APPLICATION.csproj", "CMSSERVICE.APPLICATION/"]
COPY ["CMSSERVICE.DOMAIN/CMSSERVICE.DOMAIN.csproj", "CMSSERVICE.DOMAIN/"]
COPY ["CMSSERVICE.INFRASTRUCTURE/CMSSERVICE.INFRASTRUCTURE.csproj", "CMSSERVICE.INFRASTRUCTURE/"]
COPY ["CMSSERVICE.PRESENTATION/CMSSERVICE.PRESENTATION.csproj", "CMSSERVICE.PRESENTATION/"]
RUN dotnet restore "CMSSERVICE.WEB/CMSSERVICE.WEB.csproj"
COPY . .
WORKDIR "/src/CMSSERVICE.WEB"
RUN dotnet build "CMSSERVICE.WEB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CMSSERVICE.WEB.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CMSSERVICE.WEB.dll"]