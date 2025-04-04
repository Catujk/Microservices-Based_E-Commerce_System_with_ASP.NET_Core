using ECommerce.Catalog.DTOs.ProductDetailDTOs;

namespace ECommerce.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task CreateProductDetailAsync(CreateProductDetailDTO createProductDetailDTO);
        Task UpdateProductDetailAsync(UpdateProductDetailDTO updateProductDetailDTO);
        Task DeleteProductDetailAsync(string id);
        Task<List<ResultProductDetailDTO>> GetAllProductDetailsAsync();
        Task<GetByIdProductDetailDTO> GetByIdProductDetailAsync(string id);
    }
}
