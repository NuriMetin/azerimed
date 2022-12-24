using lObjectIntegration.Domain.Core.Enums;
using lObjectIntegration.Infrastructure.Core.LObjectConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lObjectIntegration.Infrastructure.GeneralIntegration
{
    public class TestDal
    {
        public void Foo()
        {
            UnityObjects.UnityApplication UnityApp = UnityConnection.ConnectToLogo(Enums.FirmNr._001_).Login();
        }
    }
}
