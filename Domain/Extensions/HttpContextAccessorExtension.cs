using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Domain.Extensions
{
    public static class HttpContextAccessorExtension
    {
        public static Guid? UserId(this IHttpContextAccessor httpContextAccessor)
        {
            var identity = httpContextAccessor?.HttpContext?.User.Identity as ClaimsIdentity;
            var userId = identity?.FindFirst(ClaimTypes.Sid)?.Value;

            return userId != null ? new Guid(userId) : null;
        }

        public static string? UserIdString(this IHttpContextAccessor httpContextAccessor)
        {
            var identity = httpContextAccessor?.HttpContext?.User.Identity as ClaimsIdentity;
            var userId = identity?.FindFirst(ClaimTypes.Sid)?.Value;

            return userId != null ? userId : null;
        }
    }
}
