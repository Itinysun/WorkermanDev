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
            FileWatch.OnFileWatchSuccess += FileWatch_OnFileWatchSuccess;
            FileWatch.OnFileWatchFaild += FileWatch_OnFileWatchFaild;
            ConfigFile.OnConfigFileError += WriteErrorLog;
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
            OnLogWrite?.Invoke(new LogEvent.LogWriteEventArgs { content=e.Message });

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
