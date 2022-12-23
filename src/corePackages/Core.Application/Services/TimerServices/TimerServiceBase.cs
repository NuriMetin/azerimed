using Core.Application.Services.BackgroundServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Application.Services.TimerServices
{
    public class TimerServiceBase
    {
        public async Task InvokeTimer(Func<Task> func, TimeSpan periodInterval)
        {
            var task = Task.Run(async () =>
             {
                 while (true)
                 {
                     try
                     {
                         await func();
                     }

                     catch
                     {

                     }

                     await Task.Delay(periodInterval);

                     GC.Collect();
                 }
             });
        }
    }
}
