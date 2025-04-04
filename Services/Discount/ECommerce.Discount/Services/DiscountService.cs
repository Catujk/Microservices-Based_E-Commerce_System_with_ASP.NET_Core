using Dapper;
using ECommerce.Discount.Context;
using ECommerce.Discount.DTOs;

namespace ECommerce.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _dapperContext;

        public DiscountService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateCouponAsync(CreateCouponDTO createCouponDTO)
        {
            var query = "INSERT INTO Coupons (CouponCode, DiscountAmount, ExpirationDate, IsActive) VALUES (@CouponCode, @DiscountAmount, @ExpirationDate, @IsActive)";
            var parameters = new DynamicParameters();
            parameters.Add("CouponCode", createCouponDTO.CouponCode);
            parameters.Add("DiscountAmount", createCouponDTO.DiscountAmount);
            parameters.Add("ExpirationDate", createCouponDTO.ExpirationDate);
            parameters.Add("IsActive", createCouponDTO.IsActive);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async Task DeleteCouponAsync(int id)
        {
            var query = "DELETE FROM Coupons WHERE CouponID = @CouponID";
            var parameters = new DynamicParameters();
            parameters.Add("CouponID", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIdCouponDTO> GetByIdCouponAsync(int id)
        {
            var query = "SELECT * FROM Coupons WHERE CouponID = @CouponID";
            var parameters = new DynamicParameters();
            parameters.Add("CouponID", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                var coupon = await connection.QuerySingleOrDefaultAsync<GetByIdCouponDTO>(query, parameters);
                return coupon;
            }

        }

        public async Task<List<ResultCouponDTO>> GettAllCouponsAsync()
        {
            var query = "SELECT * FROM Coupons";
            using (var connection = _dapperContext.CreateConnection())
            {
                var coupons = await connection.QueryAsync<ResultCouponDTO>(query);
                return coupons.ToList();
            }   
        }

        public async Task UpdateCouponAsync(UpdateCouponDTO updateCouponDTO)
        {
            var query = "UPDATE Coupons SET CouponCode = @CouponCode, DiscountAmount = @DiscountAmount, ExpirationDate = @ExpirationDate, IsActive = @IsActive WHERE CouponID = @CouponID";
            var parameters = new DynamicParameters();
            parameters.Add("CouponID", updateCouponDTO.CouponID);
            parameters.Add("CouponCode", updateCouponDTO.CouponCode);
            parameters.Add("DiscountAmount", updateCouponDTO.DiscountAmount);
            parameters.Add("ExpirationDate", updateCouponDTO.ExpirationDate);
            parameters.Add("IsActive", updateCouponDTO.IsActive);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
