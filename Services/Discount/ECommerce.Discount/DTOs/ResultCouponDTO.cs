namespace ECommerce.Discount.DTOs
{
    public class ResultCouponDTO
    {
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
