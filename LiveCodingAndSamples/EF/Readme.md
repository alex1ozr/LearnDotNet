# EF Core Sample

## Projects
### Store
EF Core poject with entities & migrations

## Migrations
### Setup
```
dotnet tool install --global dotnet-ef
```

### Add new migrations
```
dotnet ef migrations add <migration name> --startup-project EF/ConsoleApp --project EF/Store --context PeopleContext
```

### Update database
```
dotnet ef database update --project EF/ConsoleApp --context PeopleContext
```