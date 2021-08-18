using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkermanDev.Lib;
using System.Drawing;

namespace WorkermanDev.Event
{
    class LogEvent
    {
        public delegate void LogHandle(LogWriteEventArgs e);
        public delegate void CommonLogHandle(string content);
        public delegate void ErrorLogHandle(string content,Exception e);
        public delegate void WarnLogHandle(string content);

        public class LogWriteEventArgs
        {
            public string content="";
            public Color color=Color.Black;
            public bool cleanScreen=false;
        }
    }
}
