

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["TddApi/TddApi.csproj", "TddApi/"]
COPY ["XpTdd/XpTdd.csproj", "XpTdd/"]

RUN dotnet restore "TddApi/TddApi.csproj"

COPY . .

WORKDIR "/src/TddApi"

RUN dotnet publish "TddApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS Number_1

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "TddApi.dll"]FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["TddApi/TddApi.csproj", "TddApi/"]
COPY ["XpTdd/XpTdd.csproj", "XpTdd/"]

RUN dotnet restore "TddApi/TddApi.csproj"

COPY . .

WORKDIR "/src/TddApi"

RUN dotnet publish "TddApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "TddApi.dll"]