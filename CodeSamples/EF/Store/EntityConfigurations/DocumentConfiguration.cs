using LearnDotNet.Store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static LearnDotNet.Store.EntityConfigurations.ConfigurationExtensions;

namespace LearnDotNet.Store.EntityConfigurations;

public sealed class DocumentConfiguration : IEntityTypeConfiguration<Document>
{
    private const int SeriesLength = 20;
    private const int NumberLength = 255;

    public void Configure(EntityTypeBuilder<Document> builder)
    {
        builder.ConfigureDbEntity();

        builder.Property(x => x.Series)
            .HasMaxLength(SeriesLength);

        builder.Property(x => x.Number)
            .HasMaxLength(NumberLength)
            .IsRequired();

        builder.HasOne(x => x.Type)
            .WithMany()
            .HasForeignKey(x => x.TypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Documents)
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.Series);
    }
}