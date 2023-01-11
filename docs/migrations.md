# Migrations

```
cd .\src\server\WebApi\
```

```
dotnet ef database update --project ..\Core\
```

```
dotnet ef migrations add CreateDatabase --project ..\Core\
```

```
dotnet ef database drop
```