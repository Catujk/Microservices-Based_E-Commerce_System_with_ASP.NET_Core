namespace ECommerce.Discount.DTOs
{
    public class CreateCouponDTO
    {
        public string CouponCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }

    }
}
