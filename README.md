# full-project-aspnet
Building a full project in aspnet core, just for fun

# Run

Start Postgres  Database

```bash
docker compose up -d
```

Run migrations, using [dotnet-ef](https://www.nuget.org/packages/dotnet-ef/)

```bash
dotnet ef database update
```

Run Application

```bash
dotnet run
```
