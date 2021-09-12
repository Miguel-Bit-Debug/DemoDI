using DemoDI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.DependencyInjection
{
    public static class DI
    {
        public static void AddRegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
