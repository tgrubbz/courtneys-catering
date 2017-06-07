using Microsoft.Extensions.DependencyInjection;
using CourtneysCatering.DAL;

namespace CourtneysCatering.BLL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBLL(this IServiceCollection services, string connectionString)
        {
            //services.AddScoped<IUserManager, UserManager>();
            services.AddDAL(connectionString);

            return services;
        }
    }
}
