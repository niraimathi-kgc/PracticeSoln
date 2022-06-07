#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["NullableAndException/NullableAndException.csproj", "NullableAndException/"]
RUN dotnet restore "NullableAndException/NullableAndException.csproj"
COPY . .
WORKDIR "/src/NullableAndException"
RUN dotnet build "NullableAndException.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NullableAndException.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NullableAndException.dll"]