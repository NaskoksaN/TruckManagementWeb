﻿using System.ComponentModel.DataAnnotations;

namespace TruckManagementWeb.Core.Models.User
{
    public class LoginFormModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } =string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }=string.Empty;

        public string? ReturnUrl {  get; set; }
    }
}
