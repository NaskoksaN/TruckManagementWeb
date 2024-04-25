using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.SellOrder
{
    public class DateForm
    {
        [Display(Name = "Loading Date")]
        public DateTime LoadingDateTime { get; set; }

        [Display(Name = "Delivery Date")]
        public DateTime DeliveryDateTime {  get; set; }
    }
}
