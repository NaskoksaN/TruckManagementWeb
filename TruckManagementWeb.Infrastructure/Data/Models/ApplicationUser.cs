using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TruckManagementWeb.Core.Models.ApplicationUser
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Required]
        [DisplayName("E-mail")]
        [EmailAddress()]
        public string UserEmail {  get; set; }=string.Empty;
    }
}
