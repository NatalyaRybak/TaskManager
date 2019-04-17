using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Tools
{
    public static class StationManager
    {
        public static event Action StopThreads;

        public static void InvokeStopThreads()
        {
            try
            {
                StopThreads?.Invoke();
            }
            catch { }
        }


    }
}
