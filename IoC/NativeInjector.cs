using DemoDI.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IoC
{
    public static class NativeInjector
    {
        public static void AddRegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
