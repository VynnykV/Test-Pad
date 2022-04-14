using Microsoft.AspNetCore.Identity;
using TestPad.DAL.Context;
using TestPad.DAL.Entities;

namespace TestPad.WebAPI.Extensions;

public static class ServiceCollectionExtensions
{
    public static void ConfigureAuth(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddIdentity<User, IdentityRole<int>>(opts =>
            {
                opts.Password.RequiredLength = 8;
                opts.Password.RequireDigit = true;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireLowercase = false;
            })
            .AddEntityFrameworkStores<TestPadContext>();
    }
}