using LearnDotNet.Store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LearnDotNet.Store;

public sealed class PeopleContext : DbContext
{
    private const string DbFileName = "people.db";

    public DbSet<Person> People => Set<Person>();

    public DbSet<Document> Documents => Set<Document>();

    public DbSet<DocumentType> DocumentTypes => Set<DocumentType>();

    public PeopleContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=../{DbFileName}")
            .LogTo(Console.WriteLine, LogLevel.Information);
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}