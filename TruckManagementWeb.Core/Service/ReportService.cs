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
        public ReportService(IRepository _repository)
        {
            repository = _repository;
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
            bool active = true;
            var result = await repository.AllReadOnlyAsync<Truck>()
                    .Where(t=>t.IsActive==active)
                    .Include(t => t.Trips)
                    .Include(ex => ex.Expenses)
                    .Select(t => new TrucksMonthlyViewReport
                    {
                        TruckId = t.Id,
                        PlateNumber = t.TruckPlate,
                        TotalKilometers = t.Trips!=null 
                                        ? t.Trips
                                        .Where(tr => tr.StartDate >= lastMonthStart
                                                && tr.StartDate <= lastMonthEnd)
                                        .Sum(tr => tr.TripKm)
                                        : 0,
                        TotalEuros = t.Trips != null
                                        ? t.Trips
                                    .Where(tr => tr.StartDate >= lastMonthStart
                                                && tr.StartDate <= lastMonthEnd)
                                    .Sum(tr => tr.TripPrice)
                                    : 0,
                        TotalExpenses = t.Expenses != null
                                        ? t.Expenses
                                        .Where(ex => ex.ExpenseDate >= lastMonthStart
                                                    && ex.ExpenseDate <= lastMonthEnd)
                                        .Sum(ex => ex.Amount)
                                        : 0
                    })
                    .ToListAsync();

            return result;
        }

        public async Task<TruckMonthReportViewModel> GetTruckPeriodResultAsync(string truckPlate
                                        , DateTime lastMonthStart
                                        , DateTime lastMonthEnd)
        {
            var active = true;
            var result = await repository.AllReadOnlyAsync<Truck>()
               .Where(t => t.TruckPlate == truckPlate && t.IsActive==active)
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

        public async Task<List<TruckMonthSimpleViewModel>> GetTrucksMonthlyResultAsync(DateTime firstDay
                                                                                       , DateTime lastDay)
        {
            List<TruckMonthSimpleViewModel> result = new List<TruckMonthSimpleViewModel>();
            bool active = true;
            var trucks = await repository.AllReadOnlyAsync<Truck>()
                .Where(t=> t.IsActive==active)
                .Include(tr => tr.Trips)
                .Include(tr => tr.Expenses)
                .ToListAsync();

            foreach (var truck in trucks)
            {
                var monthlyResult = new TruckMonthSimpleViewModel
                {
                    PlateNumber = truck.TruckPlate,
                    TotalKilometers = truck.Trips != null
                        ? truck.Trips
                            .Where(tr => tr.StartDate >= firstDay && tr.StartDate <= lastDay)
                            .Sum(tr => tr.TripKm)
                        : 0,
                    TotalEuros = truck.Trips != null
                        ? truck.Trips
                            .Where(tr => tr.StartDate >= firstDay && tr.StartDate <= lastDay)
                            .Sum(tr => tr.TripPrice)
                        : 0,
                    TotalExpenses = truck.Expenses != null
                        ? truck.Expenses
                            .Where(ex => ex.ExpenseDate >= firstDay && ex.ExpenseDate <= lastDay)
                            .Sum(ex => ex.Amount)
                        : 0
                };

                monthlyResult.EuroPerKm = (monthlyResult.TotalKilometers > 0 && monthlyResult.TotalEuros > 0)
                    ? (monthlyResult.TotalEuros / monthlyResult.TotalKilometers).ToString("F2")
                    : "N/A";

                result.Add(monthlyResult);
            }

            return result;
        }

        public async Task<List<TruckMonthSimpleViewModel>> GetTrucksYearResultAsync()
        {
            DateTime today = DateTime.Today;

            List<TruckMonthSimpleViewModel> yearlyResults = new List<TruckMonthSimpleViewModel>();

            bool active = true;
            List<Truck> trucks = await repository.AllReadOnlyAsync<Truck>()
                .Where(t=>t.IsActive==active)
                .Include(tr => tr.Trips)
                .Include(tr => tr.Expenses)
                .ToListAsync();

            foreach (var truck in trucks)
            {
                DateTime lastMonthEnd = today.AddDays(-today.Day);
                DateTime oneYearAgoStart = today.AddYears(-1).AddDays(1 - today.Day);

                var truckYearResult = new TruckMonthSimpleViewModel
                {
                    PlateNumber = truck.TruckPlate,
                    TotalKilometers = truck.Trips != null
                        ? truck.Trips
                            .Where(tr => tr.StartDate >= oneYearAgoStart && tr.StartDate <= lastMonthEnd)
                            .Sum(tr => tr.TripKm)
                        : 0,
                    TotalEuros = truck.Trips != null
                        ? truck.Trips
                            .Where(tr => tr.StartDate >= oneYearAgoStart && tr.StartDate <= lastMonthEnd)
                            .Sum(tr => tr.TripPrice)
                        : 0,
                    TotalExpenses = truck.Expenses != null
                        ? truck.Expenses
                            .Where(ex => ex.ExpenseDate >= oneYearAgoStart && ex.ExpenseDate <= lastMonthEnd)
                            .Sum(ex => ex.Amount)
                        : 0
                };

                truckYearResult.EuroPerKm = (truckYearResult.TotalKilometers > 0 && truckYearResult.TotalEuros > 0)
                    ? (truckYearResult.TotalEuros / truckYearResult.TotalKilometers).ToString("F2")
                    : "N/A";

                yearlyResults.Add(truckYearResult);
            }

            return yearlyResults;
        }


        public async Task<IEnumerable<TruckMonthSimpleViewModel>> GetTruckYearReport(string truckPlate)
                                       
        {
            List<TruckMonthSimpleViewModel> monthlyResults 
                                = new List<TruckMonthSimpleViewModel>();
            DateTime today = DateTime.Today;
            bool active = true;
            for (int i = 1; i <= 12; i++)
            {
                DateTime lastMonthStart = today.AddMonths(-i).AddDays(1 - today.Day);
                DateTime lastMonthEnd = lastMonthStart.AddMonths(1).AddDays(-1);

                TruckMonthSimpleViewModel? truck = await repository.AllReadOnlyAsync<Truck>()
                    .Include(trip => trip.Trips)
                    .Where(t => t.TruckPlate == truckPlate && t.IsActive == active)
                    .Select(t => new TruckMonthSimpleViewModel()
                    {
                        PlateNumber = t.TruckPlate,
                        TotalKilometers = t.Trips !=null ?
                                t.Trips
                                .Where(tr => tr.StartDate >= lastMonthStart && tr.StartDate <= lastMonthEnd)
                                .Select(tr => tr.TripKm)
                                .Sum()
                                : 0,
                        TotalEuros = t.Trips != null ?
                                t.Trips
                                .Where(tr => tr.StartDate >= lastMonthStart && tr.StartDate <= lastMonthEnd)
                                .Select(tr => tr.TripPrice)
                                .Sum()
                                : 0,
                        TotalExpenses = t.Expenses != null ?
                                t.Expenses
                                .Where(ex => ex.ExpenseDate >= lastMonthStart && ex.ExpenseDate <= lastMonthEnd)
                                .Select(ex => ex.Amount)
                                .Sum()
                                : 0,
                        Month = lastMonthStart,
                    }).FirstOrDefaultAsync();

                if(truck.TotalEuros >0 && truck.TotalExpenses >0)
                {
                    truck.EuroPerKm = (truck.TotalEuros / truck.TotalKilometers).ToString("F2");
                }
                else
                {
                    truck.EuroPerKm = "N/A";
                }

                monthlyResults.Add(truck);
            }

            return monthlyResults;
        }

        public async Task<List<ReportRevenueFromCompany>> YearlyCompanyRevenueAsync()
        {
            bool active = true;
            List<Company> companies = await repository
                                .AllReadOnlyAsync<Company>()
                                .Where(c=>c.IsActive==active)
                                .Include(o => o.Orders)
                                .ToListAsync();
            DateTime today = DateTime.Today;

            List<ReportRevenueFromCompany> yearlyResults = new List<ReportRevenueFromCompany>();

            foreach (Company company in companies)
            {
                DateTime lastMonthEnd = today.AddDays(-today.Day);
                DateTime oneYearAgoStart = today.AddYears(-1).AddDays(1 - today.Day);

                ReportRevenueFromCompany revenue = new()
                {
                    CompanyName = company.CompanyName,
                    Vat = company.CompanyVat,
                    CompanyCountry = company.CompanyCountry,
                    RevenueFromCompany = company.Orders != null
                                ? company.Orders
                                .Where(o => o.LoadingDate >= oneYearAgoStart && o.LoadingDate <= lastMonthEnd)
                               .Sum(o => o.Price)
                               : 0.00M,
                    TotalOrderCount = company.Orders != null
                            ? company.Orders.Count() : 0
                };

                yearlyResults.Add(revenue);
            }

            return yearlyResults;
        }
    }
}
