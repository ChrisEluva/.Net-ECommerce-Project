using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ModelPOCO;

namespace SampleECommerce
{
    public class ECommerceEntities: DbContext
    {
        public virtual IDbSet<Customers> Customers { get; set; }
        public virtual IDbSet<Orders> Orders { get; set; }
        public virtual IDbSet<OrderDetails> OrderDetails { get; set; }
        public virtual IDbSet<Products> Products { get; set; }
        public virtual IDbSet<Suppliers> Suppliers { get; set; }
        public virtual IDbSet<ShoppingCart> ShoppingCart { get; set; }

    }
}
