#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["numberPatternPrograms/numberPatternPrograms.csproj", "numberPatternPrograms/"]
COPY ["ClassLibrary1/ClassLibrary1.csproj", "ClassLibrary1/"]
COPY ["ExtensionMethod/ExtensionMethod.csproj", "ExtensionMethod/"]
COPY ["OopsConceptPractice/StaticClassPractice.csproj", "OopsConceptPractice/"]
COPY ["SealedClassEx/SealedClassEx.csproj", "SealedClassEx/"]
COPY ["W3schoolsPractice/W3schoolsPractice.csproj", "W3schoolsPractice/"]
COPY ["StructureSample/StructureSample.csproj", "StructureSample/"]
COPY ["CalculatorApplication/CalculatorApplication.csproj", "CalculatorApplication/"]
COPY ["NullableAndException/NullableAndException.csproj", "NullableAndException/"]
COPY ["BasicsForKarthik/StackConcept.csproj", "BasicsForKarthik/"]
RUN dotnet restore "numberPatternPrograms/numberPatternPrograms.csproj"
COPY . .
WORKDIR "/src/numberPatternPrograms"
RUN dotnet build "numberPatternPrograms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "numberPatternPrograms.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "numberPatternPrograms.dll"]