using lObjectIntegration.Infrastructure.Core.LObjectConnections.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lObjectIntegration.Domain.Core.Enums.Enums;

namespace lObjectIntegration.Infrastructure.Core.LObjectConnections
{
    public sealed class UnityConnection
    {
        public static IUnityConnection ConnectToLogo(FirmNr firmNr)
        {
            switch (firmNr)
            {
                case FirmNr._001_: return Firm001.GetInstance;
                case FirmNr._500_: return Firm500.GetInstance;
                case FirmNr._650_: return Firm650.GetInstance;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
