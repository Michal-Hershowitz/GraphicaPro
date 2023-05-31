using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bl.Profiles;
using Dal.Interface;
using Dal.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bl
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddServicesBL(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CustomerProfile));
            services.AddTransient<IServicesCustomer, ServicesCustomer>();
            return services;

            services.AddAutoMapper(typeof(EmployeeProfile));
            services.AddTransient<IServicesEmployee, ServicesEmployee>();
            return services;
        }
    }
}
