using ECommerce.Order.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1440;Initial Catalog=ECommerce_OrderDB;User Id=sa;Password=1234567aA*;Trust Server Certificate=True");
            //base.OnConfiguring(optionsBuilder);  
        }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
