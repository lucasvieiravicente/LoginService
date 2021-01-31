using LoginService.Domain.Repositories;
using LoginService.Domain.Repositories.Interfaces;
using LoginService.Services;
using LoginService.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LoginService.Domain.DIs
{
    public static class DIConfig
    {
        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IUserLoginService, UserLoginService>();
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserLoginRepository, UserLoginRepository>();
        }
    }
}
