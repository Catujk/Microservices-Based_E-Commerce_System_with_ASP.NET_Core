using ECommerce.Catalog.DTOs.ProductDetailDTOs;
using ECommerce.Catalog.Services.ProductDetailServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _productDetailService;

        public ProductDetailsController(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductDetailList()
        {
            var productDetails = await _productDetailService.GetAllProductDetailsAsync();
            return Ok(productDetails);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(string id)
        {
            var productDetail = await _productDetailService.GetByIdProductDetailAsync(id);
            if (productDetail == null)
            {
                return NotFound();
            }
            return Ok(productDetail);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDTO createProductDetailDTO)
        {
            if (createProductDetailDTO == null)
            {
                return BadRequest("Product detail data is null");
            }
            await _productDetailService.CreateProductDetailAsync(createProductDetailDTO);
            return Ok("Product detail added.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Product detail ID is null or empty");
            }
            await _productDetailService.DeleteProductDetailAsync(id);
            return Ok("Product detail deleted.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDTO updateProductDetailDTO)
        {
            if (updateProductDetailDTO == null)
            {
                return BadRequest("Product detail data is null");
            }
            await _productDetailService.UpdateProductDetailAsync(updateProductDetailDTO);
            return Ok("Product detail updated.");
        }
    }
}
