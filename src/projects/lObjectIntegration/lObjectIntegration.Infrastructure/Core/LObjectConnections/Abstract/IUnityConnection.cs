using lObjectIntegration.Domain.Core.Enums;
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
        UnityApplication Login();
        void Logout();
    }
}
