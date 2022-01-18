using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace core3api.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            var r = user.FindFirst(JwtRegisteredClaimNames.Name)?.Value;
            return r;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}