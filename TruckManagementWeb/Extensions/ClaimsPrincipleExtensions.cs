﻿using System.Security.Claims;

using static TruckManagementWeb.Core.Constants.RoleConstants;

namespace TruckManagementWeb.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRole);
        }

        public static bool IsManager(this ClaimsPrincipal user)
        {
            return user.IsInRole(ManagerRole);
        }
    }
}
