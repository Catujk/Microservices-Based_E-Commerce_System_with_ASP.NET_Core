using ECommerce.Discount.DTOs;

namespace ECommerce.Discount.Services
{
    public interface IDiscountService
    {
        Task CreateCouponAsync(CreateCouponDTO createCouponDTO);
        Task UpdateCouponAsync(UpdateCouponDTO updateCouponDTO);
        Task DeleteCouponAsync(int id);
        Task<List<ResultCouponDTO>> GettAllCouponsAsync();
        Task<GetByIdCouponDTO> GetByIdCouponAsync(int id);
    }
}
