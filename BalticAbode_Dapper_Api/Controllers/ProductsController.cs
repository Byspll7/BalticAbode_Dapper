using BalticAbode_Dapper_Api.Repositories.ProductRepository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }

        [HttpGet("ProductDealOfTheDayStatusChangeTotTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeTotTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeTotTrue(id);
            return Ok("Ads has been added successfully");
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToFalse (int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeTotTrue(id);
            return Ok("Ads has been updated successfully");
        }
    }
}
