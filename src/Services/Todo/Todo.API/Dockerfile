FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY src/Services/Todo/Todo.API/Todo.API.csproj src/Services/Todo/Todo.API/
RUN dotnet restore "src/Services/Todo/Todo.API/Todo.API.csproj"
COPY . .
WORKDIR "/src/src/Services/Todo/Todo.API"
RUN dotnet build "Todo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Todo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Todo.API.dll"]
