using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using WorkermanDev.Event;
using System.Runtime.InteropServices;

namespace WorkermanDev.Lib
{
    class MainProcess
    {
        static Process processHandle;
        static ProcessStartInfo startInfo = new ProcessStartInfo();
        static DebounceDispatcher debounceDispatcher = new DebounceDispatcher(2000);
        static string[] hideErrors = new string[] {
            "'nproc' is not recognized as an internal or external command,",
            "operable program or batch file."
        };



        public static event ProcessEvent.ProcessOutputHandle OnReadStdOutput;
        public static event LogEvent.ErrorLogHandle OnProcessError;
        public static event ProcessEvent.ProcessStateChangeHandle OnProcessStart;
        public static event ProcessEvent.ProcessStateChangeHandle OnProcessEnd;

        private static bool _inited =false;
        public static bool inited {
            get
            {
                return _inited;
            }
            set
            {
                _inited = value;
            }
        }

        public static void SetDeBounce(int seconds)
        {
            debounceDispatcher = new DebounceDispatcher(seconds*1000);
        }

        public static void Start()
        {
            try
            {
                processHandle = new Process
                {
                    StartInfo = startInfo,
                };
                processHandle.OutputDataReceived += new DataReceivedEventHandler(Process_DataReceived);
                processHandle.ErrorDataReceived += new DataReceivedEventHandler(Process_ErrorReceived);
                processHandle.Exited += new EventHandler(Process_Exited);
                processHandle.EnableRaisingEvents = true;

                processHandle.Start();
                processHandle.BeginOutputReadLine();
                processHandle.BeginErrorReadLine();

                OnProcessStart?.Invoke(processHandle);

                SeedIdFile();

            }catch(Exception e)
            {
                OnProcessError?.Invoke("Try start main process but failde !", e);
            }
        }

        public static void Stop()
        {
            if (processHandle == null || processHandle.HasExited)
                return;
            processHandle.Kill();
            processHandle.WaitForExit(5000);
        }

        public static void Restart()
        {
            try
            {
                debounceDispatcher.Debounce(() =>
                {
                    Stop();
                    Start();
                });
            }
            catch (Exception e)
            {
                OnProcessError?.Invoke("Try to Restart process faild :" , e);
            }
        }
        private static void SeedIdFile()
        {
            try
            {
                if (processHandle != null && !processHandle.HasExited)
                {
                    string id = processHandle.Id.ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        File.WriteAllText("pid", id);
                    }
                }
            }
            catch
            {

            }
        }

        public static void Clear()
        {
            if (!File.Exists("pid"))
                return;
            int id = 0;
            try
            {
               var sid = File.ReadAllText("pid");
                if (!string.IsNullOrEmpty(sid))
                {
                    id = int.Parse(sid);
                }
            }
            catch
            {

            }
            if (id > 0)
            {
                try
                {
                    var ps = Process.GetProcessById(id);
                    if (null != ps)
                    {
                        ps.Kill();
                    }
                }
                catch
                {

                }

            }

        }

        public static void Init(string php,string start)
        {
            startInfo.FileName = php;
            startInfo.Arguments = start;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            //startInfo.Verb = "RunAs";
        }

        private static void Process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                OnReadStdOutput?.Invoke(e.Data);
            }
        }

        private static void Process_ErrorReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null && !hideErrors.Contains(e.Data))
            {
                OnProcessError?.Invoke("Error on receive data from main process",new Exception(e.Data));
            }
        }

        private static void Process_Exited(object sender, EventArgs e)
        {
            OnProcessEnd?.Invoke(processHandle);
        }




    }
}
