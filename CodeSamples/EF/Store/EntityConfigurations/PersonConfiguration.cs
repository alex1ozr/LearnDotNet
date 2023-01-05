using LearnDotNet.Store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnDotNet.Store.EntityConfigurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    private const int NameLength = 255;

    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ConfigureDbEntity();

        builder.Property(p => p.FirstName)
            .HasMaxLength(NameLength)
            .IsRequired();

        builder.Property(p => p.LastName)
            .HasMaxLength(NameLength)
            .IsRequired();
    }
}