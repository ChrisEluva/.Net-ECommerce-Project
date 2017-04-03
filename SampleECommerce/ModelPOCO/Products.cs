using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPOCO
{
    public class Products
    {
        public int ProductsID { get; set; }

        [Required(ErrorMessage = "Product Name is a required field")]
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public decimal Price { get; set; }
        public int QuantityPerUnit { get; set; }
    }
}
