# Start from the .NET 8 SDK base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

EXPOSE 80

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . ./

# Publish the application
RUN dotnet publish -c Release -o out

# Start a new stage from the .NET 8 runtime base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set the working directory
WORKDIR /app

# Set the ASPNETCORE_ENVIRONMENT environment variable to Development
#ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_ENVIRONMENT=Production

# Copy the published app from the build stage
COPY --from=build /app/out .

# Set the entry point of the application
ENTRYPOINT ["dotnet", "Inventory.dll"]

#Use port 443 for HTTPS redirection
#ENV ASPNETCORE_HTTPS_PORT=443

#Only use for .Net 8 applications
ENV ASPNETCORE_URLS=http://+:80
