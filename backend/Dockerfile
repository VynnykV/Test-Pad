FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestPad.WebAPI/TestPad.WebAPI.csproj", "TestPad.WebAPI/"]
COPY ["TestPad.BLL/TestPad.BLL.csproj", "TestPad.BLL/"]
COPY ["TestPad.Common/TestPad.Common.csproj", "TestPad.Common/"]
COPY ["TestPad.DAL/TestPad.DAL.csproj", "TestPad.DAL/"]

RUN dotnet restore "TestPad.WebAPI/TestPad.WebAPI.csproj"
COPY . .
WORKDIR "/src/TestPad.WebAPI"
RUN dotnet build "TestPad.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestPad.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestPad.WebAPI.dll"]
