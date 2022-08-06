using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        //[DisplayFormat(DataFormatString ="{0:0.0#}")]
        public decimal Price { get; set; }
        [Display(Name = "Item Description")]
        public string ItemDescription { get; set; }
    }
}
