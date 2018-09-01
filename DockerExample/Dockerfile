FROM microsoft/dotnet:2.1-sdk
WORKDIR /app

COPY . .

ENV ASPNETCORE_URLS http://+:5000

RUN dotnet restore
RUN dotnet publish ./DockerExample.csproj -c Release -o /publish/

WORKDIR /publish/
ENTRYPOINT ["dotnet", "DockerExample.dll"]