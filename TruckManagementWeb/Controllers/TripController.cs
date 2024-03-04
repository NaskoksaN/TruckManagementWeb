using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Infrastructure.Data.Common;

namespace TruckManagementWeb.Controllers
{
    public class TripController : Controller
    {
        private readonly IRepository repository;
        public TripController(IRepository _repository)
        {
            repository = _repository;
        }
    }
}
