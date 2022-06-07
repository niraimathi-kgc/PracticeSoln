#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["W3schoolsPractice/W3schoolsPractice.csproj", "W3schoolsPractice/"]
RUN dotnet restore "W3schoolsPractice/W3schoolsPractice.csproj"
COPY . .
WORKDIR "/src/W3schoolsPractice"
RUN dotnet build "W3schoolsPractice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "W3schoolsPractice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "W3schoolsPractice.dll"]