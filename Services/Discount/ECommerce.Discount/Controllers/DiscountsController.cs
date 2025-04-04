using ECommerce.Discount.DTOs;
using ECommerce.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCoupons()
        {
            var result = await _discountService.GettAllCouponsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCouponById(int id)
        {
            var result = await _discountService.GetByIdCouponAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoupon([FromBody] CreateCouponDTO createCouponDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _discountService.CreateCouponAsync(createCouponDTO);
            return Ok("Coupon added."); 
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCoupon([FromBody] UpdateCouponDTO updateCouponDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _discountService.UpdateCouponAsync(updateCouponDTO);
            return Ok("Coupon updated.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoupon(int id)
        {
            var coupon = await _discountService.GetByIdCouponAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
            await _discountService.DeleteCouponAsync(id);
            return Ok("Coupon deleted.");
        }
    }
}
