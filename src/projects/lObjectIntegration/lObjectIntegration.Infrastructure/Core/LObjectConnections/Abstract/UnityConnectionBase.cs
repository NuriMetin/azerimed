using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityObjects;
using lObjectIntegration.Domain.Core.Enums;

namespace lObjectIntegration.Infrastructure.Core.LObjectConnections.Abstract
{
    public class UnityConnectionBase
    {

        public static UnityApplication Login(UnityApplication _unityApp, Enums.FirmNr firmNr, Enums.Period period)
        {
            if (!_unityApp.LoggedIn)
            {
                try
                {
                    _unityApp.Login("AVTO FAKTURALAMA", "1511", (int)firmNr, (int)period);
                }

                catch (Exception exp)
                {
                    throw new Exception(exp.Message);
                }
            }

            if (_unityApp.LoggedIn)
            {
                // _unity.UserLogout();
            }

            else
            {
                throw new Exception(_unityApp.GetLastErrorString());
            }

            return _unityApp;
        }

        public static void Logout(ref UnityApplication _unityApp)
        {
            try
            {
                int processId = _unityApp.GetPID();
                _unityApp = null;
                KillLogoObject(processId);
            }

            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        private static void KillLogoObject(int processId)
        {
            if (processId != 0)
            {
                var process = Process.GetProcessById(processId);
                process.Kill();
            }
        }
    }
}
