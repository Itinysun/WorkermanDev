using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkermanDev.Event;
using System.Drawing;

namespace WorkermanDev.Lib
{
    class LogWriter
    {
        public static event LogEvent.LogHandle OnLogWrite;
        public static void BeginProcessEvent()
        {
            MainProcess.OnReadStdOutput += WriteCommonLog;
            MainProcess.OnProcessError += WriteErrorLog;
            MainProcess.OnProcessStart += MainProcess_OnProcessStart;
            MainProcess.OnProcessEnd += MainProcess_OnProcessEnd;

            FileWatch.OnFileWatchSuccess += FileWatch_OnFileWatchSuccess;
            FileWatch.OnFileWatchFaild += FileWatch_OnFileWatchFaild;

            ConfigFile.OnConfigFileSuccess += WriteCommonLog;
            ConfigFile.OnConfigFileError += WriteErrorLog;
            ConfigFile.OnConfigFileWarn += WriteCommonLog;
        }

        private static void MainProcess_OnProcessEnd(System.Diagnostics.Process p)
        {
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs
            {
                //cleanScreen = true,
                content = "Main Process Exit",
                color = Color.Red
            });
        }

        private static void MainProcess_OnProcessStart(System.Diagnostics.Process p)
        {
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs {
                cleanScreen = true,
                content = "Main Process Started,pid="+p.Id,
                color = Color.Green
            });
        }

        private static void FileWatch_OnFileWatchFaild(string path)
        {
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs { content="Faild to watch path, may be path not exisit!"+path, color = Color.Yellow });
        }

        private static void FileWatch_OnFileWatchSuccess(string path)
        {
            WriteCommonLog("Add path moniter:" + path);
        }
        public static void WriteCommonLog(string content)
        {
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs { content=content });
        }
        public static void WriteErrorLog(string content,Exception e)
        {
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs { content = content,color=Color.Red });
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs { content=e.Message, color = Color.Red });

        }
        public static void CleanScreen(string content = "")
        {
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs { cleanScreen = true });
        }
        public static void WriteLog(LogEvent.LogWriteEventArgs e)
        {
            OnLogWrite?.Invoke(e);
        }
    }
}
