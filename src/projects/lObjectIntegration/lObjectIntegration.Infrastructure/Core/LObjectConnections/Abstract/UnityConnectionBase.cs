using lObjectIntegration.Domain.GeneralIntegration.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityObjects;
using static lObjectIntegration.Domain.GeneralIntegration.Enums.Enums;

namespace lObjectIntegration.Infrastructure.Core.LObjectConnections.Abstract
{
    public class UnityConnectionBase : IUnityConnection
    {

        public UnityApplication Connect(string userName, string password, Enums.Period period)
        {
            UnityApplication _unity = new UnityApplication();

            if (!_unity.LoggedIn)
            {
                try
                {
                    _unity.Login(userName, password, (int)period);
                }

                catch (Exception exp)
                {
                    throw new Exception(exp.Message);
                }
            }

            if (_unity.LoggedIn)
            {
                // _unity.UserLogout();
            }

            else
            {
                throw new Exception(_unity.GetLastErrorString());
            }

            return _unity;
        }

        public void Disconnect(ref UnityApplication _unity)
        {
            try
            {
                int processId = _unity.GetPID();
                _unity = null;
                KillLogoObject(processId);
            }

            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        private void KillLogoObject(int processId)
        {
            if (processId != 0)
            {
                var process = Process.GetProcessById(processId);
                process.Kill();
            }
        }
    }
}
