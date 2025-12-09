# Use the official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy all files and publish the project
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Use the smaller runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published files
COPY --from=build /app/publish .

# Expose port 8080 (Render default)
EXPOSE 8080

# Set ASP.NET Core port
ENV ASPNETCORE_URLS=http://+:8080

# Start the application
ENTRYPOINT ["dotnet", "YourProject.dll"]
