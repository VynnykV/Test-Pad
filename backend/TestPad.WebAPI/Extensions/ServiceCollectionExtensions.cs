using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TestPad.BLL.Interfaces;
using TestPad.BLL.MappingProfiles;
using TestPad.BLL.Services;
using TestPad.DAL.Context;
using TestPad.DAL.Entities;

namespace TestPad.WebAPI.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ITestService, TestService>();
    }
    
    public static void AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetAssembly(typeof(UserProfile)));
    }
    
    public static IApplicationBuilder MigrateDb(this IApplicationBuilder builder)
    {
        using var scope = builder.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
        using var context = scope?.ServiceProvider.GetRequiredService<TestPadContext>();
        context?.Database.Migrate();

        return builder;
    }
    
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
        
        services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = configuration["JWTSettings:ValidAudience"],
                    ValidIssuer = configuration["JWTSettings:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWTSettings:Secret"]))
                };
            });
    }
}