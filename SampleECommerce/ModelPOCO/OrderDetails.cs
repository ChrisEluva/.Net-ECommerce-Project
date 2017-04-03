using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPOCO
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        [Required]
        public int ProductID { get; set; }
        //public int OrderNumber { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

    }
}
