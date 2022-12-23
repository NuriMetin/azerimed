using lObjectIntegration.Domain.GeneralIntegration.Enums;
using lObjectIntegration.Infrastructure.Core.LObjectConnections.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityObjects;

namespace lObjectIntegration.Infrastructure.Core.LObjectConnections
{
    public class Firm001 : UnityConnectionBase
    {
        private readonly IUnityApplication _unityApp;
        private Firm001()
        {
            _unityApp = Connect("AVTO FAKTURALAMA", "1511", Enums.Period.CurrentPeriod);
        }
    }
}
