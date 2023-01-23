FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

WORKDIR /src
COPY ["TeeChartRazorLibrary/.", "TeeChartRazorLibrary/"]
COPY ["WASMApp/.", "WASMApp/"]
RUN dotnet restore "WASMApp/WASMApp.sln"
RUN dotnet build WASMApp/WASMApp.sln -c Release -o /app/build

FROM build AS publish
RUN dotnet publish WASMApp/WASMApp.sln -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf
