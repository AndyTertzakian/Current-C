using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Current_C.Utility
{
    static class InternetUtility
    {

        private static int Error = 0;

        public static bool InternetConnected()
        {
            long dwConnectionFlags = 0;
            return !(!InternetGetConnectedState(dwConnectionFlags, 0) || InternetAttemptConnect(0) != Error);
        }

        [DllImport("wininet.dll", SetLastError = true)]
        public static extern int InternetAttemptConnect(uint res);

        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetGetConnectedState(long flags, long reserved);
    }
}
