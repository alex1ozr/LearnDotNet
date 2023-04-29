using LearnDotNet.Store.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnDotNet.Store.EntityConfigurations;

internal static class ConfigurationExtensions
{
    public static void ConfigureDbEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : class, IDbEntity
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();
    }
}