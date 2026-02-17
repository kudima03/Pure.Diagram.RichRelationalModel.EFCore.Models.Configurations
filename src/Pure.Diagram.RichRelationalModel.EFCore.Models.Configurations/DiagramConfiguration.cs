using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pure.Primitives.Abstractions.EFCore.Converters;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations;

public sealed record DiagramConfiguration : IEntityTypeConfiguration<DiagramEFCoreModel>
{
    public void Configure(EntityTypeBuilder<DiagramEFCoreModel> builder)
    {
        _ = builder.HasKey(x => x.Id);

        _ = builder
            .Property(x => x.Id)
            .ValueGeneratedNever()
            .IsRequired()
            .HasConversion(new GuidTypeConverter());

        _ = builder
            .Property(x => x.Title)
            .IsRequired()
            .HasConversion(new StringTypeConverter())
            .HasMaxLength(64);

        _ = builder
            .Property(x => x.Description)
            .IsRequired()
            .HasConversion(new StringTypeConverter());

        _ = builder
            .Property(x => x.TypeId)
            .IsRequired()
            .HasConversion(new GuidTypeConverter());

        _ = builder.HasOne(x => x.TypeNavigation).WithMany().HasForeignKey(x => x.TypeId);

        _ = builder
            .HasMany(x => x.SeriesNavigation)
            .WithOne()
            .HasForeignKey(x => x.DiagramId);
    }
}
