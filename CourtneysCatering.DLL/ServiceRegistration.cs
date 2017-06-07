using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;

namespace CourtneysCatering.DAL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDAL(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IDbConnection>(new SqlConnection(connectionString));
            //services.AddScoped<IUserManager, UserManager>();

            return services;
        }
    }
}
