using LearnDotNet.Store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnDotNet.Store.EntityConfigurations;

public sealed class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    private const int NameLength = 255;

    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ConfigureDbEntity();

        builder.Property(x => x.FirstName)
            .HasMaxLength(NameLength)
            .IsRequired();

        builder.Property(x => x.LastName)
            .HasMaxLength(NameLength)
            .IsRequired();
    }
}