FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/netproject.Web.Host/netproject.Web.Host.csproj", "src/netproject.Web.Host/"]
COPY ["src/netproject.Web.Core/netproject.Web.Core.csproj", "src/netproject.Web.Core/"]
COPY ["src/netproject.Application/netproject.Application.csproj", "src/netproject.Application/"]
COPY ["src/netproject.Core/netproject.Core.csproj", "src/netproject.Core/"]
COPY ["src/netproject.EntityFrameworkCore/netproject.EntityFrameworkCore.csproj", "src/netproject.EntityFrameworkCore/"]
WORKDIR "/src/src/netproject.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/netproject.Web.Host", "src/netproject.Web.Host"]
COPY ["src/netproject.Web.Core", "src/netproject.Web.Core"]
COPY ["src/netproject.Application", "src/netproject.Application"]
COPY ["src/netproject.Core", "src/netproject.Core"]
COPY ["src/netproject.EntityFrameworkCore", "src/netproject.EntityFrameworkCore"]
WORKDIR "/src/src/netproject.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "netproject.Web.Host.dll"]
