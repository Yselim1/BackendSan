# Use .NET 8 SDK 
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set working directory
WORKDIR /app

# Copy everything 
COPY . ./

# Restore dependencies
RUN dotnet restore

# Expose API port
EXPOSE 5045

# Run with hot-reload support
CMD ["dotnet", "run", "--urls", "http://0.0.0.0:5045"]
