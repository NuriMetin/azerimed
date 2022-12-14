using AutoMapper;
using lObjectIntegration.Application.GeneralIntegration;
using lObjectIntegration.Infrastructure.GeneralIntegration;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lObjectIntegration.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServicesCollection(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<TestApp>();
            //services.AddScoped<BrandBusinessRules>();
            // services.AddScoped<AuthBusinessRules>();

            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            //services.AddScoped<IAuthService, AuthManager>();
            return services;

        }
    }
}
