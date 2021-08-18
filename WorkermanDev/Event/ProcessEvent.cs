using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WorkermanDev.Event
{
    public class ProcessEvent
    {
        public delegate void ProcessOutputHandle(string result);
        public delegate void ProcessStateChangeHandle(Process p);
    }
}
