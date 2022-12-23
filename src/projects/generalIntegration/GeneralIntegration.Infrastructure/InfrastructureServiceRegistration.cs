
using Core.Infrastructure.AdoNet;
using GeneralIntegration.Domain.Entities;
using GeneralIntegration.Infrastructure.Abstract;
using GeneralIntegration.Infrastructure.Concrete;
using GeneralIntegration.Infrastructure.Concrete.AdoNet;
using GeneralIntegration.Infrastructure.Concrete.AdoNet.DatabaseConnections;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            ConnectionStrings.LOGO = configuration["ConnectionStrings:LOGO"];
            ConnectionStrings.TestRep = configuration["ConnectionStrings:TestRep"];
            
            services.AddScoped<IReindexResultRepository, ReindexResultRepository>();

            services.AddSingleton<ITestRespository, TestRespository>();
            services.AddSingleton<IItemRespository, ItemRespository>();

            return services;
        }
    }
}
