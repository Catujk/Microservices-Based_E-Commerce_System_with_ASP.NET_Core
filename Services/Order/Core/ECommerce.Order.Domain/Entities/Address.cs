﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Domain.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public string UserID { get; set; }
        public string AddressCity { get; set; }
        public string AddressDistrict { get; set; }
        public string AddressDetail { get; set; }

    }
}
