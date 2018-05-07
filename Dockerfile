FROM microsoft/aspnetcore-build:latest
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore-build:latest
WORKDIR /app
COPY --from /app/out .
ENTRYPOINT ["dotnet", "aspnetapp.dll"]