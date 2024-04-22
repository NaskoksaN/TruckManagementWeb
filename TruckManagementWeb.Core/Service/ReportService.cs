using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Enumeration;
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
        /// <summary>
        /// Retrieves the truck result for the last month along with a string title indicating the period.
        /// </summary>
        /// <returns>
        /// A tuple containing the title string and a list of TruckMonthSimpleViewModel representing the monthly result.
        /// </returns>
        public async Task<(string title, List<TruckMonthSimpleViewModel> monthlyResult)> GetMonthlyTrucksResultAsync()
        {
            DateTime today = DateTime.Today;
            string period = "month";
            DateTime firstDayOfLastMonth = new DateTime(today.Year, today.Month - 1, 1);
            DateTime lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1);

            List<TruckMonthSimpleViewModel> monthlyResult = await GetTrucksMonthlyResult(firstDayOfLastMonth, lastDayOfLastMonth);

            string title = GetTitle(monthlyResult,
                period,
                firstDayOfLastMonth,
                lastDayOfLastMonth);

            return (title, monthlyResult);
        }

        /// <summary>
        /// Retrieves the yearly financial results of trucks.
        /// </summary>
        /// <returns>
        /// A tuple containing the title summarizing the period and a list of TruckMonthSimpleViewModel objects, each representing financial data from a truck for the year.
        /// </returns>
        public async Task<(string title, List<TruckMonthSimpleViewModel> monthlyResult)> GetTrucksYearResultAsync()
        {
            DateTime today = DateTime.Today;
            string period = "year";
            DateTime lastMonthEnd = today.AddDays(-today.Day);
            DateTime oneYearAgoStart = today.AddYears(-1).AddDays(1 - today.Day);

            List<TruckMonthSimpleViewModel> yearlyResults = await GetTrucksMonthlyResult(oneYearAgoStart, lastMonthEnd);
            
            string title = GetTitle(yearlyResults,
                period,
                oneYearAgoStart,
                lastMonthEnd);

            return (title, yearlyResults);
        }

        /// <summary>
        /// Retrieves a yearly report for a specified truck, including monthly statistics on kilometers traveled, expenses, and profits.
        /// </summary>
        /// <param name="truckPlate">The license plate number of the truck for which the report is generated.</param>
        /// <returns>An enumerable collection of <see cref="TruckMonthSimpleViewModel"/> representing monthly statistics for the specified truck.</returns>
        public async Task<IEnumerable<TruckMonthSimpleViewModel>> GetTruckYearReport(string truckPlate)
        {
            List<TruckMonthSimpleViewModel> monthlyResults = new List<TruckMonthSimpleViewModel>();
            DateTime today = DateTime.Today;
            bool active = true;

            DateTime lastDayOfPreviousMonth = new DateTime(today.Year, today.Month, 1).AddDays(-1);
            DateTime firstDayOneYearAgo = lastDayOfPreviousMonth.AddYears(-1).AddDays(1);

            var truckData = await repository.AllReadOnlyAsync<Truck>()
                .Where(truck =>
                    truck.TruckPlate == truckPlate &&
                    truck.IsActive == active)
                .Include(truck => truck.Trips.Where(trip => trip.StartDate >= firstDayOneYearAgo && trip.StartDate <= lastDayOfPreviousMonth))
                .Include(truck => truck.Expenses.Where(expense => expense.ExpenseDate >= firstDayOneYearAgo && expense.ExpenseDate <= lastDayOfPreviousMonth))
                .ToListAsync();

            for (int i = 0; i < 12; i++)
            {
                DateTime currentMonth = lastDayOfPreviousMonth.AddMonths(-i);

                var truckMonthData = truckData.Select(truck => new TruckMonthSimpleViewModel
                {
                    PlateNumber = truck.TruckPlate,
                    TotalKilometers = truck.Trips != null ? truck.Trips
                        .Where(trip => trip.StartDate.Month == currentMonth.Month && trip.StartDate.Year == currentMonth.Year)
                        .Select(trip => trip.TripKm)
                        .Sum() : 0,
                    TotalEuros = truck.Trips != null ? truck.Trips
                        .Where(trip => trip.StartDate.Month == currentMonth.Month && trip.StartDate.Year == currentMonth.Year)
                        .Select(trip => trip.TripPrice)
                        .Sum() : 0,
                    TotalExpenses = truck.Expenses != null ? truck.Expenses
                        .Where(expense => expense.ExpenseDate.Month == currentMonth.Month && expense.ExpenseDate.Year == currentMonth.Year)
                        .Select(expense => expense.Amount)
                        .Sum() : 0,
                    Month = currentMonth,
                }).FirstOrDefault();

                if (truckMonthData != null)
                {
                    if (truckMonthData.TotalKilometers > 0 && truckMonthData.TotalEuros > 0)
                    {
                        truckMonthData.EuroPerKm = (truckMonthData.TotalEuros / truckMonthData.TotalKilometers).ToString("F2");
                    }
                    else
                    {
                        truckMonthData.EuroPerKm = "N/A";
                    }

                    monthlyResults.Add(truckMonthData);
                }
            }

            return monthlyResults;
        }

        /// <summary>
        /// Retrieves the current month financial result of given truck.
        /// </summary>
        /// <param name="truckPlate"></param>
        /// <returns></returns>
        public Task<TruckMonthReportViewModel> TruckCurrentMonthAsync(string truckPlate)
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfCurrentMonth = new DateTime(today.Year, today.Month, 1);

            return GetTruckPeriodResultAsync(truckPlate, firstDayOfCurrentMonth, today);
        }

        /// <summary>
        /// Retrieves the last month financial result of given truck with trips and orders.
        /// </summary>
        /// <param name="truckPlate"></param>
        /// <returns></returns>
        public Task<TruckMonthReportViewModel> TruckLastMonthAsync(string truckPlate)
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfLastMonth = new DateTime(today.Year, today.Month - 1, 1);
            DateTime lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1);

            return GetTruckPeriodResultAsync(truckPlate, firstDayOfLastMonth, lastDayOfLastMonth);
        }

        /// <summary>
        /// Retrieves the last quarter  financial result of given truck with trips and orders.
        /// </summary>
        /// <param name="truckPlate"></param>
        /// <returns></returns>
        public async Task<List<TruckMonthReportViewModel>> TruckLastQuarterAsync(string truckPlate)
        {
            DateTime today = DateTime.Today;

            List<TruckMonthReportViewModel> truckReport = new List<TruckMonthReportViewModel>();

            DateTime currentMonthStartDate = new DateTime(today.Year, today.Month, 1);


            currentMonthStartDate = currentMonthStartDate.AddMonths(-1);

            for (int i = 0; i < 3; i++)
            {
                DateTime startDate = currentMonthStartDate.AddMonths(-i);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                var truckMonthly = await GetTruckPeriodResultAsync(truckPlate, startDate, endDate);

                truckReport.Insert(0, truckMonthly);
            }

            return truckReport;
        }

        /// <summary>
        /// Retrieves the yearly revenue data from companies within the last year.
        /// </summary>
        public async Task<(string title, List<ReportRevenueFromCompany>)> YearlyCompanyRevenueAsync()
        {
            DateTime today = DateTime.Today;
            string period = "year";
            DateTime lastMonthEnd = today.AddDays(-today.Day).AddDays(-1);
            DateTime oneYearAgoStart = today.AddYears(-1).AddDays(1 - today.Day);
            bool active = true;

            List<Company> companies = await repository
                                .AllReadOnlyAsync<Company>()
                                .Where(c => c.IsActive == active)
                                .Include(o => o.Orders.Where(o => o.LoadingDate >= oneYearAgoStart &&
                                                            o.LoadingDate <= lastMonthEnd))
                                .ToListAsync();
            List<ReportRevenueFromCompany> yearlyResults = new List<ReportRevenueFromCompany>();

            foreach (Company company in companies)
            {
                ReportRevenueFromCompany revenue = new()
                {
                    CompanyName = company.CompanyName,
                    Vat = company.CompanyVat,
                    CompanyCountry = company.CompanyCountry,
                    RevenueFromCompany = company.Orders != null
                                ? company.Orders
                               .Sum(o => o.Price)
                               : 0.00M,
                    TotalOrderCount = company.Orders != null
                            ? company.Orders.Count() : 0
                };

                yearlyResults.Add(revenue);
            }
            string title = $"Income from Companies for last year ({oneYearAgoStart.ToString("dd/MM/yyyy")} - {lastMonthEnd.ToString("dd/MM/yyyy")})";
            return (title, yearlyResults);
        }

        /// <summary>
        /// Filters and sorts company revenue data based on the provided criteria.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="searchTerm"></param>
        /// <param name="sorting"></param>
        /// <param name="currentPgae"></param>
        /// <param name="companyPerPage"></param>
        /// <returns></returns>
        public async Task<CompanyRevenueQueryModel> FilteredCompanyRevenue(string? country,
                            string? searchTerm,
                            CompanyRevenueSorting sorting = CompanyRevenueSorting.None
                            ,int currentPgae = 1,
                            int companyPerPage = 6)
        {
            var(title, companiesToShow) = await YearlyCompanyRevenueAsync();

            if (!string.IsNullOrEmpty(country))
            {
                companiesToShow = companiesToShow
                                    .Where(c => c.CompanyCountry.ToLower() == country.ToLower())
                                    .ToList();
            }
            if(searchTerm!=null)
            {
                companiesToShow = companiesToShow
                                    .Where(c=>c.CompanyName.ToLower().Contains(searchTerm.ToLower()))
                                    .ToList();
            }

            companiesToShow = sorting switch
            {
                CompanyRevenueSorting.HighestIncome => companiesToShow
                                                .OrderByDescending(c => c.RevenueFromCompany)
                                                .ToList(),
                CompanyRevenueSorting.LowestIncome => companiesToShow
                                        .OrderBy(c => c.RevenueFromCompany)
                                        .ToList(),
                _ => companiesToShow
            };

            int totalCountOfcompany = companiesToShow.Count;

            var model = new CompanyRevenueQueryModel()
            {
                TotalCompanyCount = companiesToShow.Count,
                RevenueReports = companiesToShow
            };

            return model;
        }

        /// <summary>
        /// Retrieves overall information about trucks, including total truck count, total traveled kilometers, and total orders made within the current year.
        /// </summary>
        /// </summary>
        /// <returns></returns>
        public async Task<OveralTrucksInfoViewModel> OveralInfo()
        {
            DateTime yearBeginning = new DateTime (DateTime.Now.Year,1,1);
            DateTime currentDate = DateTime.Now;
            bool activity = true;

            var truckCount = await repository.AllReadOnlyAsync<Truck>()
                        .Where(t => t.IsActive == activity)
                        .CountAsync();

            var kmCount = await repository.AllReadOnlyAsync<Trip>()
                .Where(t => t.StartDate >= yearBeginning && t.StartDate <= currentDate)
                .Select(t=>t.TripKm)
                .SumAsync();

            var orderCount = await repository.AllReadOnlyAsync<Order>()
                .Where(t => t.LoadingDate >= yearBeginning && t.DeliveryDate <= currentDate)
                .CountAsync();

            OveralTrucksInfoViewModel result = new OveralTrucksInfoViewModel()
            {
                TotaltruckCount = truckCount,
                TotalTraveledKm = kmCount,
                TotalOrdersMade = orderCount
            };


            return result;
        }

        /// <summary>
        /// Retrieves the financial report for truck within a given period.
        /// </summary>
        /// /// <param name="truckPlate">The plate number of the truck.</param>
        /// <param name="lastMonthStart">The start date of the period.</param>
        /// <param name="lastMonthEnd">The end date of the period.</param>
        private async Task<TruckMonthReportViewModel> GetTruckPeriodResultAsync(string truckPlate
                                        , DateTime lastMonthStart
                                        , DateTime lastMonthEnd)
        {
            var active = true;
            var result = await repository.AllReadOnlyAsync<Truck>()
               .Where(t => t.TruckPlate == truckPlate && t.IsActive == active)
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

        /// <summary>
        /// Retrieves the financial report for All trucks within a given period.
        /// </summary>
        private async Task<List<TruckMonthSimpleViewModel>> GetTrucksMonthlyResult(DateTime firstDay,
                                                                    DateTime lastDay)
        {
            List<TruckMonthSimpleViewModel> result = new List<TruckMonthSimpleViewModel>();
            bool active = true;
            var trucks = await repository.AllReadOnlyAsync<Truck>()
                .Where(t => t.IsActive == active)
                .Include(tr => tr.Trips.Where(trip => trip.StartDate >= firstDay && trip.StartDate <= lastDay))
                .Include(tr => tr.Expenses.Where(expense => expense.ExpenseDate >= firstDay && expense.ExpenseDate <= lastDay))
                .ToListAsync();

            foreach (var truck in trucks)
            {
                var monthlyResult = new TruckMonthSimpleViewModel
                {
                    PlateNumber = truck.TruckPlate,
                    TotalKilometers = truck.Trips != null
                        ? truck.Trips
                            .Sum(tr => tr.TripKm)
                        : 0,
                    TotalEuros = truck.Trips != null
                        ? truck.Trips
                            .Sum(tr => tr.TripPrice)
                        : 0,
                    TotalExpenses = truck.Expenses != null
                        ? truck.Expenses
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

        /// <summary>
        /// Generates a title summarizing the financial results of trucks for a given period.
        /// </summary>
        private string GetTitle(List<TruckMonthSimpleViewModel> truckPeriod, 
                                    string period, 
                                    DateTime startPeriod,
                                    DateTime endPeriod)
        {

            decimal profit = truckPeriod.Sum(t => t.TotalEuros) - truckPeriod.Sum(t => t.TotalExpenses);
            string profitLabel = profit >= 0 ? "Profit" : "Loss";

            string titleResult = $"Trucks last {period} ({startPeriod.ToString("dd/MM/yyyy")} - {endPeriod.ToString("dd/MM/yyyy")}) Result: {profitLabel} {Math.Abs(profit)} euro";

            return titleResult;
        }

    }
}
