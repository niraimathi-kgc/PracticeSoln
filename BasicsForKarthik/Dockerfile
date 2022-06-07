#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["BasicsForKarthik/StackConcept.csproj", "BasicsForKarthik/"]
RUN dotnet restore "BasicsForKarthik/StackConcept.csproj"
COPY . .
WORKDIR "/src/BasicsForKarthik"
RUN dotnet build "StackConcept.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StackConcept.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StackConcept.dll"]