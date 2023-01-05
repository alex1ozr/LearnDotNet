using LearnDotNet.Store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static LearnDotNet.Store.EntityConfigurations.ConfigurationExtensions;

namespace LearnDotNet.Store.EntityConfigurations;

public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
{
    private const int NameLength = 255;

    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.ConfigureDbEntity();

        builder.Property(p => p.Name)
            .HasMaxLength(NameLength)
            .IsRequired();
        
        builder.Property(p => p.Name)
            .HasMaxLength(NameLength)
            .IsRequired();
    }
}