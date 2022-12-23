using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services.BackgroundServices
{
    public interface IBackgroundService
    {
        Task InvokeServiceAsync();
        Task LockService();
    }
}
