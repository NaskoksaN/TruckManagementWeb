using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Reports;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Core.Service
{
    public class ReportService : IReports
    {
        private readonly IRepository repository;
        private readonly ITruckService truckService;
        public ReportService(IRepository _repository,
            ITruckService _truckService)
        {
            repository = _repository;
            truckService = _truckService;
        }

        public async Task<IEnumerable<TrucksMonthlyViewReport>> GetAllTruckMonthlyResult()
        {
            DateTime lastMonthStart = DateTime
                           .Today
                           .AddMonths(-1)
                           .Date
                           .AddDays(1 - DateTime.Today.Day);
            DateTime lastMonthEnd = DateTime
                                .Today
                                .AddDays(-DateTime.Today.Day);

            var result = await repository.AllReadOnlyAsync<Truck>()
                    .Include(t => t.Trips)
                    .Include(ex => ex.Expenses)
                    .Select(t => new TrucksMonthlyViewReport
                    {
                        TruckId = t.Id,
                        PlateNumber = t.TruckPlate,
                        TotalKilometers = t.Trips
                                        .Where(tr => tr.StartDate >= lastMonthStart
                                                && tr.StartDate <= lastMonthEnd)
                                        .Sum(tr => tr.TripKm),
                        TotalEuros = t.Trips
                                    .Where(tr => tr.StartDate >= lastMonthStart
                                                && tr.StartDate <= lastMonthEnd)
                                    .Sum(tr => tr.TripPrice),
                        TotalExpenses = t.Expenses
                                        .Where(ex => ex.ExpenseDate >= lastMonthStart
                                                    && ex.ExpenseDate <= lastMonthEnd)
                                        .Sum(ex => ex.Amount)
                    })
                    .ToListAsync();

            return result;
        }

        public async Task<TruckMonthReportViewModel> GetTruckPeriodResultAsync(string truckPlate, DateTime lastMonthStart, DateTime lastMonthEnd)
        {
            var result = await repository.AllReadOnlyAsync<Truck>()
               .Where(t => t.TruckPlate == truckPlate)
               .Select(t => new TruckMonthReportViewModel
               {
                   PlateNumber = t.TruckPlate,
                   TotalKilometers = t.Trips
                                       .Where(tr => tr.StartDate >= lastMonthStart
                                               && tr.StartDate <= lastMonthEnd)
                                       .Sum(tr => tr.TripKm),
                   TotalEuros = t.Trips
                                   .Where(tr => tr.StartDate >= lastMonthStart
                                               && tr.StartDate <= lastMonthEnd)
                                   .Sum(tr => tr.TripPrice),
                   TotalExpenses = t.Expenses
                                       .Where(ex => ex.ExpenseDate >= lastMonthStart
                                                   && ex.ExpenseDate <= lastMonthEnd)
                                       .Sum(ex => ex.Amount),
                   Trips = t.Trips
                               .Where(tr => tr.StartDate >= lastMonthStart
                                           && tr.StartDate <= lastMonthEnd)
                               .Select(tr => new Models.Trip.TripViewModel
                               {
                                   Id = tr.Id,
                                   LoadingDate = tr.StartDate,
                                   TruckPlate = truckPlate,
                                   Price = tr.TripPrice,
                                   TotalKm = tr.TripKm,
                                   EuPerKm = tr.EuPerKm.ToString("F2"),
                                   Orders = tr.Orders
                                               .Select(o => new Models.Trip.OrderViewModel
                                               {
                                                   LoadingDate = o.LoadingDate,
                                                   CompanyName = o.Company.CompanyName,
                                                   Price = o.Price,
                                                   LoadingCode = o.LoadingPostCode,
                                                   DeliveryCode = o.DeliveryPostCode
                                               })
                                               .ToList()
                               })
                               .ToList()
               })
               .FirstOrDefaultAsync();

            return result;
        }

    }
}
