FROM microsoft/aspnetcore-build:latest
WORKDIR /app
ADD /app

# Copy csproj and restore as distinct layers
COPY *.sln ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:latest
RUN mkdir /app
COPY --from=build-env /app/out /app

ENTRYPOINT ["dotnet", "aspnetapp.dll"]