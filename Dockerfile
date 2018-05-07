FROM microsoft/dotnet
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "aspnetapp.dll"]