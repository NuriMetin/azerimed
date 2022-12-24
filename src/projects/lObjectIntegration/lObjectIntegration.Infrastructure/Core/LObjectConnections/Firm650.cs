using lObjectIntegration.Domain.Core.Enums;
using lObjectIntegration.Infrastructure.Core.LObjectConnections.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityObjects;

namespace lObjectIntegration.Infrastructure.Core.LObjectConnections
{
    public class Firm650 : IUnityConnection
    {
        private static readonly object InstanceLock = new object();
        private static readonly object UnityLock = new object();

        private static Firm650 instance = null;
        private static UnityApplication _unityApp = null;

        private Firm650() { }

        public static Firm650 GetInstance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Firm650();
                    }

                    return instance;
                }
            }
        }

        public UnityApplication Login()
        {
            lock (UnityLock)
            {
                if (_unityApp == null)
                {
                    _unityApp = new UnityApplication();
                }

                UnityConnectionBase.Login(_unityApp, Enums.FirmNr._650_, Enums.Period.CurrentPeriod);
            }

            return _unityApp;
        }


        public void Logout()
        {
            UnityConnectionBase.Logout(ref _unityApp);
        }
    }
}