using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WorkermanDev.Event;

namespace WorkermanDev.Lib
{
    class ExceptionWriter
    {
        private static string basePath;
        public static event LogEvent.CommonLogHandle OnExceptionSaveError;
        public static void Save(Exception ex)
        {
            try
            {
                string filePath = CheckPath();
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("-----------------------------------------------------------------------------");
                    writer.WriteLine("Date : " + DateTime.Now.ToString());
                    writer.WriteLine();

                    while (ex != null)
                    {
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }catch(Exception e)
            {
                OnExceptionSaveError?.Invoke("Can not save your exception!" + e.Message);
            }

        }
        public static string CheckPath()
        {
            if (null == basePath)
            {
                basePath = Path.Combine(Environment.CurrentDirectory, "Log");
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }
            }
            return Path.Combine(basePath, DateTime.Now.ToString("yyyymmdd-hhiiss-")+ DateTime.Now.Millisecond.ToString() + ".log");
        }
    }
}
