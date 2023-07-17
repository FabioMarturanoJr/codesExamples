FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY *.sln .

COPY ./InMemoryCrud/InMemoryCrud.Api.csproj ./InMemoryCrud/
COPY ./InMemoryCrud.Application/InMemoryCrud.Application.csproj ./InMemoryCrud.Application/
COPY ./InMemoryCrud.AutoMapper/InMemoryCrud.AutoMapper.csproj ./InMemoryCrud.AutoMapper/
COPY ./InMemoryCrud.Domain/InMemoryCrud.Domain.csproj ./InMemoryCrud.Domain/
COPY ./InMemoryCrud.Infrastructure/InMemoryCrud.Infrastructure.csproj ./InMemoryCrud.Infrastructure/
COPY ./InMemoryCrud.IoC/InMemoryCrud.IoC.csproj ./InMemoryCrud.IoC/

COPY . ./
WORKDIR /app/InMemoryCrud
RUN dotnet publish -c Release -o publish

ENV PORT=$PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY --from=build /app/InMemoryCrud/publish  ./

ENV ASPNETCORE_URLS=http://+:PORT
ENV TZ=America/Recife
ENTRYPOINT ["dotnet", "InMemoryCrud.Api.dll"]
