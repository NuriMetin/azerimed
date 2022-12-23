using Core.Application.Services.TimerServices;
using GeneralIntegration.Application.ReindexResult.Services.BackgroundServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.ReindexResult.Services.TimerServices
{
    public interface IReindexResultTimerService
    {
        Task InvokeTimerByInterval(IReindexResultBackgroundService service, TimeSpan interval);
    }
}
