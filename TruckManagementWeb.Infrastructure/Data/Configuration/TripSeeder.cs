using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public static class TripSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            int numberOfTrucks = 6;
            int numberOfCompanies = 10;
            int dispo1Id = 3;
            int dispo2Id = 4;

            DateTime startDate = new DateTime(2023, 6, 1); // June 2023
            DateTime endDate = DateTime.UtcNow.Date;

            int months = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;

            decimal minIncomePerMonth = 950; // Minimum income per month
            decimal maxIncomePerMonth = 1300; // Maximum income per month
            int minKmPerMonth = 650; // Minimum kilometers per month
            int maxKmPerMonth = 1100; // Maximum kilometers per month

            Random rand = new Random();
            int tripIdCounter = 1;

            List<Trip> trips = new List<Trip>();
            List<Order> orders = new List<Order>();

            for (int i = 0; i <= months; i++)
            {
                DateTime currentDate = startDate.AddMonths(i);
                List<int> tripDates = new List<int> { 1, 4, 7, 10, 13, 16, 19, 22, 27 };

                foreach (int tripDate in tripDates)
                {
                    foreach (int truckIndex in Enumerable.Range(1, numberOfTrucks))
                    {
                        int companyId = rand.Next(1, numberOfCompanies + 1);
                        int dispatcherId = truckIndex % 2 == 0 ? dispo1Id : dispo2Id;

                        decimal income = (decimal)(rand.NextDouble() * ((double)maxIncomePerMonth - (double)minIncomePerMonth)) + minIncomePerMonth;
                        int km = rand.Next(minKmPerMonth, maxKmPerMonth);

                        Trip trip = new Trip
                        {
                            Id = tripIdCounter,
                            TruckId = truckIndex,
                            TripPrice = income,
                            TripKm = km,
                            EuPerKm = income / km,
                            StartDate = currentDate.AddDays(tripDate - 1),
                            EndDate = currentDate.AddDays(tripDate),
                            EmployeeId = dispatcherId
                        };

                        trips.Add(trip);
                        tripIdCounter++;
                    }
                }
            }

            modelBuilder.Entity<Trip>().HasData(trips);

           
            foreach (Trip trip in trips)
            {
                Order order = new Order
                {
                    Id = trip.Id, 
                    Price = trip.TripPrice,
                    CompanyId = rand.Next(1, numberOfCompanies + 1),
                    TripId = trip.Id,
                    LoadingDate = trip.StartDate,
                    DeliveryDate = trip.EndDate,
                    LoadingPostCode = "Loading", 
                    DeliveryPostCode = "Delivery" 
                };

                orders.Add(order);
            }

            modelBuilder.Entity<Order>().HasData(orders);
        }
    }



}
