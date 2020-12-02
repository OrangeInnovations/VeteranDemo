using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace VeteranFunctions
{
    public static class Registration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient();
        }
    }
}
