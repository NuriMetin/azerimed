using lObjectIntegration.Domain.GeneralIntegration.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityObjects;

namespace lObjectIntegration.Infrastructure.Core.LObjectConnections.Abstract
{
    public interface IUnityConnection
    {
        UnityApplication Connect(string userName, string password, Enums.Period period);
        void Disconnect(ref UnityApplication unityApplication);
    }
}
