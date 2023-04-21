using eShopSolution.Api.Contracts.Enums;
using eShopSolution.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Email).HasMaxLength(200);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
            builder.Property(x => x.Message).HasMaxLength(200);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
