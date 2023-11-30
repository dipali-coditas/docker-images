# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy the project files to the container
COPY . .

# Build the application
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port 80 for the application
EXPOSE 5000

# Start the application
ENTRYPOINT ["dotnet", "csharp-webapp.dll"]

