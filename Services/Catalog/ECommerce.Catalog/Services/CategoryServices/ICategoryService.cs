using ECommerce.Catalog.DTOs.CategoryDTOs;

namespace ECommerce.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO);
        Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
        Task DeleteCategoryAsync(string id);
        Task<List<ResultCategoryDTO>> GetAllCategoriesAsync();
        Task<GetByIdCategoryDTO> GetByIdCategoryAsync(string id);
    }
}
