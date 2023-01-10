# TestTask3

## Migrations

Add and apply migration

```
cd .\Web
dotnet ef migrations add CreateDatabase --project ..\Core\
dotnet ef database update --project ..\Core\
```