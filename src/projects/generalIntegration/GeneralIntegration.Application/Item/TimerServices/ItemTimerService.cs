using Core.Application.Services.TimerServices;
using GeneralIntegration.Application.Item.BackgroundServices;
using GeneralIntegration.Application.Test.Services.BackgroundServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.Item.TimerServices
{
    public class ItemTimerService : TimerServiceBase, IItemTimerService
    {
        public ItemTimerService(IItemBackgroundService service)
        {
            ForGuid.GUID_TIMER_SERVICE_I = Guid.NewGuid().ToString();
            InvokeTimer(service.LockService, TimeSpan.FromSeconds(8)).GetAwaiter().GetResult();
        }
    }
}