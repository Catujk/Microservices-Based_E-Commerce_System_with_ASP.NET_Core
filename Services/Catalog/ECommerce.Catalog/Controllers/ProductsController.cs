using ECommerce.Catalog.DTOs.ProductDTOs;
using ECommerce.Catalog.Services.ProductServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var product = await _productService.GetByIdProductAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDTO createProductDTO)
        {
            if (createProductDTO == null)
            {
                return BadRequest("Product data is null");
            }
            await _productService.CreateProductAsync(createProductDTO);
            return Ok("Product added.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Product ID is null or empty");
            }
            await _productService.DeleteProductAsync(id);
            return Ok("Product deleted.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            if (updateProductDTO == null)
            {
                return BadRequest("Product data is null");
            }
            await _productService.UpdateProductAsync(updateProductDTO);
            return Ok("Product updated.");
        }


    }
}
