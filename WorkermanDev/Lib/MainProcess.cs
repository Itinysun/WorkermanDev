using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using WorkermanDev.Event;

namespace WorkermanDev.Lib
{
    class MainProcess
    {
        static Process mainProcess;
        static ProcessStartInfo startInfo = new ProcessStartInfo();
        static DebounceDispatcher debounceDispatcher = new DebounceDispatcher(2000);


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
                mainProcess = new Process
                {
                    StartInfo = startInfo
                };

                mainProcess.OutputDataReceived += new DataReceivedEventHandler(Process_DataReceived);
                mainProcess.ErrorDataReceived += new DataReceivedEventHandler(Process_ErrorReceived);
                mainProcess.Exited += new EventHandler(Process_Exited);
                mainProcess.EnableRaisingEvents = true;

                mainProcess.Start();
                mainProcess.BeginOutputReadLine();
                mainProcess.BeginErrorReadLine();
                OnProcessStart?.Invoke(mainProcess);
            }catch(Exception e)
            {
                OnProcessError?.Invoke("Try start main process but failde !", e);
            }
        }

        public static void Stop()
        {
            mainProcess.Kill();
            mainProcess.WaitForExit();
            mainProcess.Dispose();
        }

        public static void Restart()
        {
            if (mainProcess.HasExited)
                return;
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
            if (e.Data != null)
            {
                OnProcessError?.Invoke("Error on receive data from main process",new Exception(e.Data));
            }
        }

        private static void Process_Exited(object sender, EventArgs e)
        {
            OnProcessEnd?.Invoke(mainProcess);
        }




    }
}
