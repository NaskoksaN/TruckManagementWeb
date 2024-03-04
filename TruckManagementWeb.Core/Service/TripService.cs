using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Infrastructure.Data.Common;

namespace TruckManagementWeb.Core.Service
{
    public class TripService : ITripService
    {
        private readonly IRepository repository;
        public TripService(IRepository _repository)
        {
            repository = _repository;
        }

    }
}
