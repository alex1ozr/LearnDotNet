using LearnDotNet.Store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static LearnDotNet.Store.EntityConfigurations.ConfigurationExtensions;

namespace LearnDotNet.Store.EntityConfigurations;

public class DocumentConfiguration : IEntityTypeConfiguration<Document>
{
    private const int SeriesLength = 20;
    private const int NumberLength = 255;

    public void Configure(EntityTypeBuilder<Document> builder)
    {
        builder.ConfigureDbEntity();

        builder.Property(p => p.Series)
            .HasMaxLength(SeriesLength);

        builder.Property(p => p.Number)
            .HasMaxLength(NumberLength)
            .IsRequired();

        builder.HasOne(p => p.Type)
            .WithMany()
            .HasForeignKey(p => p.TypeId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(p => p.Person)
            .WithMany()
            .HasForeignKey(p => p.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}