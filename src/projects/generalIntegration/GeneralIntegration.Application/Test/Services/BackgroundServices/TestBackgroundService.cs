using AutoMapper;
using Core.Application.Dtos;
using Core.Application.Services.BackgroundServices;
using GeneralIntegration.Application.ReindexResult.Dtos;
using GeneralIntegration.Application.ReindexResult.Queries;
using GeneralIntegration.Application.Test.Services.BackgroundServices;
using GeneralIntegration.Infrastructure.Abstract;
using GeneralIntegration.Infrastructure.Concrete.AdoNet;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.Test.Services.BackgroundServices
{
    public class TestBackgroundService : ITestBackgroundService
    {
        private static readonly object Lock = new object();

        private readonly ITestRespository _testRespository;
        public TestBackgroundService(ITestRespository testRespository)
        {
            _testRespository = testRespository;
        }

        public async Task InvokeServiceAsync()
        {
            ForGuid.GUID_SERVICE = Guid.NewGuid().ToString();
            await _testRespository.Add("Test",ForGuid.GUID_CONTROLLER, ForGuid.GUID_TIMER_SERVICE, ForGuid.GUID_SERVICE);
        }

        public async Task LockService()
        {
            lock (Lock)
            {
                InvokeServiceAsync().GetAwaiter().GetResult();
            }
        }
    }
}
