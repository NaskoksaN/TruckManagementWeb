using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Data;

namespace TruckManagementWeb.Core.Service
{
    public class TruckService : ITrcukService
    {
        private readonly TruckDbContext context;
        public TruckService(TruckDbContext _context)
        {
            context = _context;
        }
    }
}
