using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Infrastructure.Abstract
{
    public interface IItemRespository
    {
        Task Add(string jobName, string guid_controller, string guid_timer_service, string guid_service);
    }
}
