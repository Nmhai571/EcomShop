using eShopSolution.Api.Contracts.Enums;
using eShopSolution.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Api.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.ApplyForAll).HasDefaultValue(true);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.ProductIds).HasMaxLength(10);
            builder.Property(x => x.ProductCategoryIds).HasMaxLength(10);

        }
    }
}
