using LearnDotNet.Store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnDotNet.Store.EntityConfigurations;

public sealed class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
{
    private const int NameLength = 255;

    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.ConfigureDbEntity();

        builder.Property(x => x.Name)
            .HasMaxLength(NameLength)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();
    }
}