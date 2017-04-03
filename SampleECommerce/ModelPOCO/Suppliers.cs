using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPOCO
{
    public class Suppliers
    {
        public int SuppliersID { get; set; }
        
        [Required]
        public string CompanyName { get; set; }
        public int Phone { get; set; }
    }
}
