using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Data
{
    public class Product : BaseEntity
    {
        [Display(Name = "Product Name")]
        public string? Pro_Name { get; set; }
        [Display(Name = "Product Description")]
        public string? Pro_Description { get; set; }
        [Display(Name = "Product Qty")]
        public int? Pro_Qty { get; set; }
        [Display(Name = "Product Price")]
        public decimal? Pro_Price { get; set; }
    }
}
