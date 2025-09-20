# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# انسخ ملف csproj من مكانه
COPY SayHello/SayHello.csproj SayHello/
RUN dotnet restore SayHello/SayHello.csproj

# انسخ بقية الملفات
COPY . .
WORKDIR /src/SayHello
RUN dotnet publish -c Release -o /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "SayHello.dll"]
