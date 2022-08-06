using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AffinitySoftwarePractical.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name ="Customer")]
        public int CustomerId { get; set; }
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime OrderDate { get; set; }

        public virtual OrderDetail OrderDetail { get; set; } = new OrderDetail();
    }
}
