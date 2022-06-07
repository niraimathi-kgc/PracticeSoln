#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["StructureSample/StructureSample.csproj", "StructureSample/"]
RUN dotnet restore "StructureSample/StructureSample.csproj"
COPY . .
WORKDIR "/src/StructureSample"
RUN dotnet build "StructureSample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StructureSample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StructureSample.dll"]