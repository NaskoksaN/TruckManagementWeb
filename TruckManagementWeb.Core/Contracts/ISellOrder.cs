using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Models.SoldOrder;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ISellOrder
    {
        Task<int> AddSoldOrderAsync(SoldOrderFormModel formModel);
        Task<SoldViewFomrModel> GetSoldOrderByIdAsync(int id);
    }
}
