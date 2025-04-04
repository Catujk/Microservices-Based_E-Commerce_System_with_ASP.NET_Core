using ECommerce.Catalog.DTOs.ProductDTOs;

namespace ECommerce.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task CreateProductAsync(CreateProductDTO createProductDTO);
        Task UpdateProductAsync(UpdateProductDTO updateProductDTO);
        Task DeleteProductAsync(string id);
        Task<List<ResultProductDTO>> GetAllProductsAsync();
        Task<GetByIdProductDTO> GetByIdProductAsync(string id);
    }
}
