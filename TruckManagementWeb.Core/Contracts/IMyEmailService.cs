using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IMyEmailService
    {
       void SendMail(string Email, string body, string fullName);
    }
}
