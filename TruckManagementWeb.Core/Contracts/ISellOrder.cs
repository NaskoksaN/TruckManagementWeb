using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Models.SellOrder;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ISellOrder
    {
        Task AddDateAsync(Guid token, DateTime? deliveryDate, string action);
        Task<int> AddSoldOrderAsync(SoldOrderFormModel formModel);
        Task<SoldViewFomrModel> GetOrderByTokenAsync(Guid token);
        Task<SoldViewFomrModel> GetSoldOrderByIdAsync(int id);
    }
}
