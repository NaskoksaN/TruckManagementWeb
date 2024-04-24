using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.SoldOrder;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

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
        public async Task AddSoldOrderAsync(SoldOrderFormModel formModel)
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
            };

            await repository.AddAsync(order);
            await repository.SaveChangesAsync();
        }
    }
}
