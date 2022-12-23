using GeneralIntegration.Application.Test.Services.BackgroundServices;
using GeneralIntegration.Infrastructure.Abstract;
using GeneralIntegration.Infrastructure.Concrete.AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Application.Item.BackgroundServices
{
    public class ItemBackgroundService : IItemBackgroundService
    {
        private static readonly object Lock = new object();

        private readonly IItemRespository _itemRespository;
        public ItemBackgroundService(IItemRespository itemRespository)
        {
            _itemRespository = itemRespository;
        }

        public async Task InvokeServiceAsync()
        {
            ForGuid.GUID_SERVICE_I = Guid.NewGuid().ToString();
            try
            {
                await _itemRespository.Add("Item", ForGuid.GUID_CONTROLLER_I, ForGuid.GUID_TIMER_SERVICE_I, ForGuid.GUID_SERVICE_I);
            }
            catch (Exception exp)
            {
                string msg = exp.Message;
            }
           
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
