using Autofac.Core;
using Core.Application.Services.TimerServices;
using GeneralIntegration.Application.ReindexResult.Services.BackgroundServices;
using GeneralIntegration.Application.Test.Services.BackgroundServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.Test.Services.TimerServices
{
    public class TestTimerService : TimerServiceBase, ITestTimerService
    {
        public TestTimerService(ITestBackgroundService service)
        {
            ForGuid.GUID_TIMER_SERVICE = Guid.NewGuid().ToString();
            InvokeTimer(service.LockService, TimeSpan.FromSeconds(3)).GetAwaiter().GetResult();
        }
    }
}