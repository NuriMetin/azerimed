using Core.Application.Services.BackgroundServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services.TimerServices
{
    public interface ITimerService
    {
        public Task InvokeTimer(IBackgroundService service, TimeSpan periodInterval);
    }
}
