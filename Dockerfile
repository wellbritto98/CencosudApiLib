FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG TARGETARCH
WORKDIR /src
COPY ["CencosudApiLib.Web/CencosudApiLib.Web.csproj", "CencosudApiLib.Web/"]
RUN dotnet restore -a $TARGETARCH "CencosudApiLib.Web/CencosudApiLib.Web.csproj"
COPY . .
WORKDIR "/src/CencosudApiLib.Web"
RUN dotnet build "CencosudApiLib.Web.csproj" -a $TARGETARCH -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CencosudApiLib.Web.csproj" -a $TARGETARCH -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "CencosudApiLib.Web.dll"]