FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 53882
EXPOSE 44362

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY PostsAPIM/PostsAPIM.csproj PostsAPIM/
RUN dotnet restore PostsAPIM/PostsAPIM.csproj
COPY . .
WORKDIR /src/PostsAPIM
RUN dotnet build PostsAPIM.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PostsAPIM.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PostsAPIM.dll"]
