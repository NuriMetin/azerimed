using AutoMapper.Configuration;
using lObjectIntegration.Infrastructure.Core.LObjectConnections;
using lObjectIntegration.Infrastructure.GeneralIntegration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lObjectIntegration.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureServicesCollection(this IServiceCollection services)
        {

            services.AddScoped<TestDal>();
            return services;
        }
    }
}
