using AutoMapper;
using Core.Application.Services.BackgroundServices;
using Core.Application.Services.TimerServices;
using GeneralIntegration.Application.Item.BackgroundServices;
using GeneralIntegration.Application.Item.TimerServices;
using GeneralIntegration.Application.ReindexResult.Services.BackgroundServices;
using GeneralIntegration.Application.ReindexResult.Services.TimerServices;
using GeneralIntegration.Application.Test.Services.BackgroundServices;
using GeneralIntegration.Application.Test.Services.TimerServices;
using GeneralIntegration.Infrastructure.Abstract;
using GeneralIntegration.Infrastructure.Concrete;
using GeneralIntegration.Infrastructure.Concrete.AdoNet;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IReindexResultTimerService, ReindexResultTimerService>();
            services.AddScoped<IReindexResultBackgroundService, ReindexResultBackgroundService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddSingleton<ITestBackgroundService, TestBackgroundService>();
            services.AddSingleton<ITestTimerService, TestTimerService>();

            services.AddSingleton<IItemBackgroundService, ItemBackgroundService>();
            services.AddSingleton<IItemTimerService, ItemTimerService>();

            //services.AddTransient<ITimerService, IItemBackgroundService>();

            //services.AddSingleton<ITest3BackgroundService, Test3BackgroundService>();
            //services.AddSingleton<ITest3TimerService, Test3TimerService>();

            return services;
        }
    }
}
