using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pure.Primitives.Abstractions.EFCore.Converters;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations;

public sealed record SeriesConfiguration : IEntityTypeConfiguration<SeriesEFCoreModel>
{
    public void Configure(EntityTypeBuilder<SeriesEFCoreModel> builder)
    {
        _ = builder.HasKey(x => x.Id);

        _ = builder
            .Property(x => x.Id)
            .ValueGeneratedNever()
            .IsRequired()
            .HasConversion(new GuidTypeConverter());

        _ = builder
            .Property(x => x.DiagramId)
            .IsRequired()
            .HasConversion(new GuidTypeConverter());

        _ = builder
            .Property(x => x.Label)
            .IsRequired()
            .HasConversion(new StringTypeConverter())
            .HasMaxLength(64);

        _ = builder
            .Property(x => x.Source)
            .IsRequired()
            .HasConversion(new StringTypeConverter())
            .HasMaxLength(64);
    }
}
