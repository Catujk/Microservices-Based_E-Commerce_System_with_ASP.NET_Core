﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Domain.Entities
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public int OrderingID { get; set; }
        public Ordering Ordering { get; set; }
    }
}
