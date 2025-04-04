using ECommerce.Catalog.DTOs.CategoryDTOs;
using ECommerce.Catalog.Services.CategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryList()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var category = await _categoryService.GetByIdCategoryAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            if (createCategoryDTO == null)
            {
                return BadRequest("Category data is null");
            }
            await _categoryService.CreateCategoryAsync(createCategoryDTO);
            return Ok("Category added.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Category ID is null or empty");
            }
            await _categoryService.DeleteCategoryAsync(id);
            return Ok("Category deleted.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            if (updateCategoryDTO == null)
            {
                return BadRequest("Category data is null");
            }
            await _categoryService.UpdateCategoryAsync(updateCategoryDTO);
            return Ok("Category updated.");
        }
    }
}
