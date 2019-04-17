using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.ViewModels
{
    public class MoreViewModel
    {
        public ProcessModuleCollection Modules
        {
            get;
        }

        public ProcessThreadCollection Threads
        {
            get;
        }

        public MoreViewModel(ProcessList process)
        {
            Threads = process.Process.Threads;
            Modules = process.Process.Modules;

        }

    }
}
