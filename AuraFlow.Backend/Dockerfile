# См. статью по ссылке https://aka.ms/customizecontainer, чтобы узнать как настроить контейнер отладки и как Visual Studio использует этот Dockerfile для создания образов для ускорения отладки.

# Этот этап используется при запуске из VS в быстром режиме (по умолчанию для конфигурации отладки)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# Этот этап используется для сборки проекта службы
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AuraFlow.Backend/AuraFlow.Backend.csproj", "AuraFlow.Backend/"]
COPY ["AuraFlow.Application/AuraFlow.Application.csproj", "AuraFlow.Application/"]
COPY ["AuraFlow.Infrastructure/AuraFlow.Infrastructure.csproj", "AuraFlow.Infrastructure/"]
COPY ["AuraFlow.Domain/AuraFlow.Domain.csproj", "AuraFlow.Domain/"]
COPY ["AuraFlow.Web/AuraFlow.WebUI.csproj", "AuraFlow.Web/"]
RUN dotnet restore "./AuraFlow.Backend/AuraFlow.Backend.csproj"
COPY . .
WORKDIR "/src/AuraFlow.Backend"
RUN dotnet build "./AuraFlow.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Этот этап используется для публикации проекта службы, который будет скопирован на последний этап
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AuraFlow.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Этот этап используется в рабочей среде или при запуске из VS в обычном режиме (по умолчанию, когда конфигурация отладки не используется)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuraFlow.Backend.dll"]