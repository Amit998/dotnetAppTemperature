# FROM mcr.microsoft.com/dotnet/core/sdk AS build
# WORKDIR /build
# COPY . . 
# RUN dotnet build --configuration Release



FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine
WORKDIR /app
COPY . . 
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "bin/Debug/netcoreapp3.1/Temperature.dll"]