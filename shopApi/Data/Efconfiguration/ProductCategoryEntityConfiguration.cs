using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopApi.Entities;

namespace shopApi.Data.Efconfiguration;

public class ProductCategoryEntityConfiguration
    : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategory");
        builder.Property(x=>x.Name)
            .IsRequired()
            .HasMaxLength(200)
            ;

        builder.HasOne(x => x.Parent)
            .WithMany(x => x.Children)
            .HasForeignKey(x => x.ParentId);

        builder.HasMany(x => x.Product)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId);
    }
}