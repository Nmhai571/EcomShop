using eShopSolution.Api.Data.DbContext;
using eShopSolution.Api.Models;

namespace eShopSolution.Api.Repository
{
    public interface IProductRepository : IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(EShopDbContext context) : base(context)
        {
        }


    }
}
