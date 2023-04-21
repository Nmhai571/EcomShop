using eShopSolution.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.Data.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(x => new { x.ProductId, x.CategoryId });

            builder.HasOne(x => x.Product).WithMany(x => x.ProductCategories).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Category).WithMany(x => x.ProductCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
