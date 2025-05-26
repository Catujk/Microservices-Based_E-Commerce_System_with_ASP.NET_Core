using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Domain.Entities
{
    public class Ordering
    {
        public int OrderingID { get; set; }
        public string UserID { get; set; }
        public decimal OrderingTotalPrice { get; set; }
        public DateTime OrderingDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
