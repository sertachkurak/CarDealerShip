using System.Security.Claims;
using CarDealership.Common;

namespace CarDealership.Web.Infrastructure
{
    using static Common.Constants.AdminConstants;
    public static class ClaimsPrincipalExtensions
    {
        public static string? GetUserId(this ClaimsPrincipal? userClaimsPrincipal)
        {
            return userClaimsPrincipal?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? null;
        }
        public static bool IsAdmin(this ClaimsPrincipal? user)
        {
            return user.IsInRole(AdminRoleName);
        }
    }
}
