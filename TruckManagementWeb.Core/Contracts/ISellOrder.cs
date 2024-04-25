﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Models.SoldOrder;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ISellOrder
    {
        Task AddDateAsync(Guid token, DateTime? deliveryDate, string action);
        Task<int> AddSoldOrderAsync(SoldOrderFormModel formModel);
        Task<SoldViewFomrModel> GetOrderByTokeAsync(Guid token);
        Task<SoldViewFomrModel> GetSoldOrderByIdAsync(int id);
    }
}
