using Core.Infrastructure.AdoNet;
using GeneralIntegration.Domain.Entities;
using GeneralIntegration.Infrastructure.Abstract;
using GeneralIntegration.Infrastructure.Concrete.AdoNet.DatabaseConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Infrastructure.Concrete.AdoNet
{
    public class ItemRespository : AdoNetRepositoryBase<ReindexResult>, IItemRespository
    {
        public async Task Add(string jobName, string guid_controller, string guid_timer_service, string guid_service)
        {
            await ExecuteCommandAsync($@"INSERT INTO TimerTest VALUES ('{jobName}', GETDATE(),'{guid_controller}','{guid_timer_service}','{guid_service}')", ConnectionStrings.TestRep);
        }
    }
}
