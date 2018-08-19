#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 50473
EXPOSE 44336

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["TodoList/TodoList.csproj", "TodoList/"]
RUN dotnet restore "TodoList/TodoList.csproj"
COPY . .
WORKDIR "/src/TodoList"
RUN dotnet build "TodoList.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TodoList.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TodoList.dll"]