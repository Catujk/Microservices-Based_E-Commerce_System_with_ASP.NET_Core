namespace ECommerce.Discount.Entities
{
    public class Coupon
    {
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
