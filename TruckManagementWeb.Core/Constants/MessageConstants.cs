using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredMessage = "The {0} is required.";
        public const string LengthMessage = "The {0} must be between {2} and {1} characters long.";
        public const string ProductionRangeMessage = "The{0} must be between {1} year nad {2} year.";
        public const string PlateMessage = "Truck plate must include uppercase letters and digits.";
    }
}
