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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.SeoDescription).HasMaxLength(200);
            builder.Property(x => x.SeoTitle).HasMaxLength(200);
            builder.Property(x => x.SeoAlias).HasMaxLength(200);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}
