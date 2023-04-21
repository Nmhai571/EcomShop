using eShopSolution.Api.Contracts.Enums;
using eShopSolution.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Api.Data.Seeding
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "this is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyWord", Value = "this is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "this is description page of eShopSolution" }
            );



            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Price = 1000000,
                    OriginalPrice = 900000,
                    Stock = 0,
                    ViewCount = 0,
                    DateCreate = DateTime.Now,
                    Name = "Áo Sơ Mi Trắng Nam",
                    Description = "Áo Sơ Mi Trắng Nam",
                    Details = "Áo Sơ Mi Trắng Nam",
                    SeoDescription = "Áo Sơ Mi Trắng Nam",
                    SeoTitle = "Áo Sơ Mi Trắng Nam",
                    SeoAlias = "ao-so-mi-trang-nam",
                },
                  new Product()
                  {
                      Id = 2,
                      Price = 1000000,
                      OriginalPrice = 900000,
                      Stock = 0,
                      ViewCount = 0,
                      DateCreate = DateTime.Now,
                      Name = "Áo Sơ Mi Trắng Nữ",
                      Description = "Áo Sơ Mi Trắng Nữ",
                      Details = "Áo Sơ Mi Trắng Nữ",
                      SeoDescription = "Áo Sơ Mi Trắng Nữ",
                      SeoTitle = "Áo Sơ Mi Trắng Nữ",
                      SeoAlias = "ao-so-mi-trang-nu",
                  }

            );



            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    SortOrder = 1,
                    IsShowinHome = true,
                    ParentId = null,
                    Status = Status.Active,
                    Name = "Áo Nam",
                    SeoDescription = "Sản Phẩm Áo Thời Trang Nam",
                    SeoTitle = "Sản Phẩm Áo Thời Trang Nam",
                    SeoAlias = "ao-nam",
                },
                new Category()
                {
                    Id = 2,
                    SortOrder = 2,
                    IsShowinHome = true,
                    ParentId = null,
                    Status = Status.Active,
                    Name = "Áo Nữ",
                    SeoDescription = "Sản Phẩm Áo Thời Trang Nữ",
                    SeoTitle = "Sản Phẩm Áo Thời Trang Nữ",
                    SeoAlias = "ao-nu",
                }
            );



            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory()
                {
                    ProductId = 1,
                    CategoryId = 1
                },
                new ProductCategory()
                {
                    ProductId = 2,
                    CategoryId = 2
                }
            );

            // any guid
            var roleId = new Guid("9B6FC39C-753F-460E-99A6-99BBD80EE262");
            var adminId = new Guid("F2994BAD-DD70-486F-9345-02CAC10A5466");
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Hai",
                LastName = "Nguyen",
                BirthDay = new DateTime(2023, 04, 10)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}
