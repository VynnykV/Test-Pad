using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using TestPad.BLL.Exceptions;

namespace TestPad.WebAPI.Extensions;

public static class ControllerBaseExtensions
{
    public static int GetUserIdFromToken(this ControllerBase controller)
    {
        var claimsUserId = controller.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrEmpty(claimsUserId))
        {
            throw new InvalidTokenException("access");
        }

        return int.Parse(claimsUserId);
    }
}