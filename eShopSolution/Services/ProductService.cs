using AutoMapper;
using eShopSolution.Api.Models;
using eShopSolution.Api.Repository;
using eShopSolution.Api.ViewModel;

namespace eShopSolution.Api.Services
{

    public interface IProductService
    {
        int Add(ProductViewModel productViewModel);
        int Update(ProductViewModel productViewModel);
        int Delete(int id);
        IEnumerable<ProductViewModel> GetAll();
        IEnumerable<ProductViewModel> GetAllPaging(int page, int pageSize, out int totalRow);
        Product GetById(int id);
    }
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }


        public int Add(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<Product>(productViewModel);
            _productRepository.Add(product);
            return product.Id;
        }

        public int Delete(int id)
        {   
            _productRepository.Delete(id);
            return id;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var data = _productRepository.GetAll(new string[] { "ProductCategories"  });
            return _mapper.Map<IEnumerable<ProductViewModel>>(data);
        }

        public IEnumerable<ProductViewModel> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductViewModel productViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
