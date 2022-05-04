using BreakfastApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BreakfastApp
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<MainService>();
        }
    }
}
