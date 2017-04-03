using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPOCO
{
    public class Orders
    {
        public int OrdersID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public int OrderNumber { get; set; }
    }
}
