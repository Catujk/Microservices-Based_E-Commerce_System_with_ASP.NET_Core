using ECommerce.Catalog.DTOs.ProductImageDTOs;

namespace ECommerce.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task CreateProductImageAsync(CreateProductImageDTO createProductImageDTO);
        Task UpdateProductImageAsync(UpdateProductImageDTO updateProductImageDTO);
        Task DeleteProductImageAsync(string id);
        Task<List<ResultProductImageDTO>> GetAllProductImagesAsync();
        Task<GetByIdProductImageDTO> GetByIdProductImageAsync(string id);
    }
}
