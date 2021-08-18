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
    class FileWatch
    {

        private static List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();
        private static List<string> filter = new List<string>();

        public static event FileWatchEvent.FileChangeHandle OnFileChanged;
        public static event FileWatchEvent.FileWatchSuccessDelegate OnFileWatchSuccess;
        public static event FileWatchEvent.FileWatchFaildDelegate OnFileWatchFaild;
        public static event LogEvent.ErrorLogHandle OnError;
       

        public  static void BeginMonitorPath(string path)
        {
            if (Directory.Exists(path))
            {
                FileSystemWatcher fs = new FileSystemWatcher(path);
                fs.Changed += FileChanged;
                fs.Renamed += FileChanged;
                fs.Deleted += FileChanged;
                fs.Created += FileChanged;
                fs.Error += Fs_Error;
                fs.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;
                fs.IncludeSubdirectories = true;
                fs.EnableRaisingEvents = true;
                OnFileWatchSuccess?.Invoke(path);
            }
            else
            {
                OnFileWatchFaild?.Invoke("path not exisit : "+ path);
            }
        }

        private static void Fs_Error(object sender, ErrorEventArgs e)
        {
            OnError?.Invoke("Error found with FileWatch : ",e.GetException());
        }
        public static void SetFilter(List<string> f)
        {
            filter = f;
        }
        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            var fi = new FileInfo(e.FullPath);
            if (filter.Count != 0)
            {
                var ext = fi.Extension.ToLower();
                if (!filter.Contains(ext))
                    return;
            }
            OnFileChanged?.Invoke(fi);
        }

    }
}
