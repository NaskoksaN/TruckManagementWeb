using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.ApplicationUser
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DisplayName("Full name")]
        [MaxLength(EmployeeNameMaxLenght)]
        public string FullName {  get; set; }=string.Empty;

    }
}
