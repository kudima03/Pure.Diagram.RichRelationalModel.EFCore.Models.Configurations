using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pure.Primitives.Abstractions.EFCore.Converters;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations;

public sealed record DiagramTypeConfiguration
    : IEntityTypeConfiguration<DiagramTypeEFCoreModel>
{
    public void Configure(EntityTypeBuilder<DiagramTypeEFCoreModel> builder)
    {
        _ = builder.HasKey(x => x.Id);

        _ = builder
            .Property(x => x.Id)
            .ValueGeneratedNever()
            .IsRequired()
            .HasConversion(new GuidTypeConverter());

        _ = builder
            .Property(x => x.Name)
            .IsRequired()
            .HasConversion(new StringTypeConverter())
            .HasMaxLength(64);

        _ = builder.HasIndex(x => x.Name).IsUnique();
    }
}
