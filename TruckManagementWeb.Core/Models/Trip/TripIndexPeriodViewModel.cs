using TruckManagementWeb.Core.Validations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ModelCountConst;

namespace TruckManagementWeb.Core.Models.Trip
{
    public class TripIndexPeriodViewModel
    {
        [DateRange(PeriodTripCountDays, ErrorMessage = TripPeriodMsg)]
        public DateTime StartDate { get; set; }

        [DateRange(PeriodTripCountDays, ErrorMessage = TripPeriodMsg)]
        public DateTime EndDate { get; set; }
    }
}
