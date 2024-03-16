using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.Trip
{
    public class TripViewModel
    {
        public int Id { get; set; }
        public DateTime LoadingDate {  get; set; }
        public string TruckPlate {  get; set; }=string.Empty ;
        public decimal Price {  get; set; }
        public int TotalKm { get; set; }
        public string EuPerKm { get; set; } = string.Empty ;

        public IEnumerable<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
    }
}
