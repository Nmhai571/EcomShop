using eShopSolution.Api.Services;
using eShopSolution.Api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("get-product")]
        public IEnumerable<ProductViewModel> GetAll()
        {
            return _productService.GetAll();
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> Add([FromBody]ProductViewModel model)
        {
            var product =  _productService.Add(model); 
            if (product == null) return BadRequest();
            return Ok(product);
            
        }

        [HttpDelete("delete-product")]
        public int Delete(int productId)
        {
            return _productService.Delete(productId);
        }
    }
}
