using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPOCO
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartID { get; set; }
        
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price {get; set;}
        public double SubTotal {get; set;}
    }
}
