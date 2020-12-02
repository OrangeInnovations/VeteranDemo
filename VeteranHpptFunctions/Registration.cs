using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace VeteranHpptFunctions
{
    public static class Registration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient();
        }
    }
}
