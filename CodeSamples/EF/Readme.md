# EF Core Sample

## Projects
### Store
EF Core poject with entities & migrations

## Migrations
### Setup
```
dotnet tool install --global dotnet-ef
```

### Add new migration
```
dotnet ef migrations add <migration name> --project EF/ConsoleApp --context PeopleContext
```

### Update database
```
dotnet ef database update --project EF/ConsoleApp --context PeopleContext
```