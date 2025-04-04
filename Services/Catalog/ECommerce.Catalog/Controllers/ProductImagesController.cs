using ECommerce.Catalog.DTOs.ProductImageDTOs;
using ECommerce.Catalog.Services.ProductImageServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductImageList()
        {
            var productImages = await _productImageService.GetAllProductImagesAsync();
            return Ok(productImages);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(string id)
        {
            var productImage = await _productImageService.GetByIdProductImageAsync(id);
            if (productImage == null)
            {
                return NotFound();
            }
            return Ok(productImage);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDTO createProductImageDTO)
        {
            if (createProductImageDTO == null)
            {
                return BadRequest("Product image data is null");
            }
            await _productImageService.CreateProductImageAsync(createProductImageDTO);
            return Ok("Product image added.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Product image ID is null or empty");
            }
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("Product image deleted.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDTO updateProductImageDTO)
        {
            if (updateProductImageDTO == null)
            {
                return BadRequest("Product image data is null");
            }
            await _productImageService.UpdateProductImageAsync(updateProductImageDTO);
            return Ok("Product image updated.");
        }
    }
}
