FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base 
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TF.WebApi/TF.WebApi.csproj", "TF.WebApi/"]
COPY ["TF.Data/TF.Data.csproj", "TF.Data/"]
COPY ["TF.Core/TF.Core.csproj", "TF.Core/"]
RUN dotnet restore "./TF.WebApi/TF.WebApi.csproj"
COPY . .
WORKDIR "/src/TF.WebApi"
RUN dotnet build "./TF.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TF.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TF.WebApi.dll"]