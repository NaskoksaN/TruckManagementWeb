using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.Reports
{
    public class OveralTrucksInfoViewModel
    {
        public int TotaltruckCount { get; set; } = 0;
        public int TotalTraveledKm { get; set; } = 0;
        public int TotalOrdersMade { get; set; } = 0;
    }
}
