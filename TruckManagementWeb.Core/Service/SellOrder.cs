using Microsoft.EntityFrameworkCore;
using System;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.SoldOrder;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TruckManagementWeb.Core.Service
{
    public class SellOrder : ISellOrder
    {
        private readonly IRepository repository;
        private readonly ICompanyService companyService;
        public SellOrder(IRepository _repository,
            ICompanyService _companyService)
        {
            repository = _repository;
            companyService = _companyService;
        }

        public async Task AddDateAsync(Guid token, DateTime? date, string action)
        {
            var order = await repository.AllAsync<SoldOrder>()
                .Where(s=> s.OrderGuid==token)
                .FirstOrDefaultAsync();

            if (order != null && date != null)
            {
                if (action == "loaded")
                {
                    order.LoadingDateTime = date;
                }
                if (action == "delivered")
                {
                    order.DeliveryDateTime = date;
                }
                await repository.SaveChangesAsync();
            }
        }

        public async Task <int>AddSoldOrderAsync(SoldOrderFormModel formModel)
        {
            var company = await companyService.FindCompanyByVatAsync(formModel.ClientCompanyVat);

            SoldOrder order = new SoldOrder()
            {
                OrderGuid = formModel.OrderGuid,
                CompanyId = company.Id,
                LoadingCompany = formModel.LoadingCompany,
                LoadingStreet = formModel.LoadingStreet,
                LoadingTown = formModel.LoadingTown,
                DeliveryCompany = formModel.DeliveryCompany,
                DeliveryStreet = formModel.DeliveryStreet,
                DeliveryTown = formModel.DeliveryTown,
                LoadingMeter = formModel.LoadingMeter,
                Weight = formModel.Weight,
                LoadingReference = formModel.LoadingReference,
                DeliveryReference = formModel.DeliveryReference,
                Price = formModel.Price,
                ClientEmail= formModel.ClientEmail
            };

            await repository.AddAsync(order);
            await repository.SaveChangesAsync();

            return order.Id;
        }

        public async Task<SoldViewFomrModel> GetOrderByTokeAsync(Guid token)
        {
            SoldViewFomrModel result = await repository.AllAsync<SoldOrder>()
                 .Where(order => order.OrderGuid == token)
                 .Select(s=> new SoldViewFomrModel()
                 {
                    OrderGuid = s.OrderGuid,
                    ClientEmail = s.ClientEmail,
                    LoadingCompany = s.LoadingCompany,
                    LoadingStreet = s.LoadingStreet,
                    LoadingTown = s.LoadingTown,
                    DeliveryCompany = s.DeliveryCompany,
                    DeliveryStreet = s.DeliveryStreet,
                    DeliveryTown = s.DeliveryTown,
                    LoadingMeter = s.LoadingMeter,
                    Weight = s.Weight,
                    LoadingReference = s.LoadingReference,
                    DeliveryReference = s.DeliveryReference,
                    Price = s.Price,
                    LoadingDateTime = s.LoadingDateTime.HasValue ? s.LoadingDateTime : null,
                    DeliveryDateTime = s.DeliveryDateTime.HasValue ? s.DeliveryDateTime : null
                 })
                 .FirstOrDefaultAsync();
            return result;
        }

        public async Task<SoldViewFomrModel> GetSoldOrderByIdAsync(int id)
        {
           
            SoldViewFomrModel result = await repository.AllReadOnlyAsync<SoldOrder>()
                .Where(s => s.Id == id)
                .Select(s=> new SoldViewFomrModel()
                {
                    OrderGuid = s.OrderGuid,
                    ClientEmail=s.ClientEmail,
                    LoadingCompany = s.LoadingCompany,
                    LoadingStreet = s.LoadingStreet,
                    LoadingTown = s.LoadingTown,
                    DeliveryCompany = s.DeliveryCompany,
                    DeliveryStreet = s.DeliveryStreet,
                    DeliveryTown = s.DeliveryTown,
                    LoadingMeter = s.LoadingMeter,
                    Weight = s.Weight,
                    LoadingReference = s.LoadingReference,
                    DeliveryReference = s.DeliveryReference,
                    Price = s.Price
                })
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
