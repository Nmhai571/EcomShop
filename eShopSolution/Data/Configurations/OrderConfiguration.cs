using eShopSolution.Api.Contracts.Enums;
using eShopSolution.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderDate);
            builder.Property(x => x.ShipName).HasMaxLength(100);
            builder.Property(x => x.ShipAddress).HasMaxLength(255);
            builder.Property(x => x.ShipEmail).HasMaxLength(255);
            builder.Property(x => x.ShipEmail).HasMaxLength(255);
            builder.Property(x => x.ShipPhoneNumber).HasMaxLength(20);
            builder.Property(x => x.Status).HasDefaultValue(OrderStatus.InProgress);
            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);

        }
    }
}
