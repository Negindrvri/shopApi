using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopApi.Entities;

namespace shopApi.Data.Efconfiguration;

public class ProductCommentEntityConfiguration
 : IEntityTypeConfiguration<ProductComment>
{
    public void Configure(EntityTypeBuilder<ProductComment> builder)
    {
        builder.ToTable("ProductComments");

        builder.Property(x => x.Body)
           .IsRequired()
           .HasMaxLength(1000);

        builder.HasOne(x => x.Product)
            .WithMany(x => x.Comments);

        builder.HasOne(x => x.User)
           .WithMany(x => x.ProductComments);

    }
}
