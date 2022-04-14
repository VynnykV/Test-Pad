using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestPad.DAL.Context;

namespace TestPad.DAL;

public static class ConfigurationExtensions
{
    public static void ConfigureDAL(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionsString = configuration["ConnectionStrings:TestPadDBConnection"];

        services.AddDbContext<TestPadContext>(options =>
            options.UseSqlServer(
                connectionsString,
                opt => opt.MigrationsAssembly(typeof(TestPadContext).Assembly.GetName().Name)));
    }
}