using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using WorkermanDev.Event;
using System.Collections.Concurrent;

namespace WorkermanDev.Lib
{
    class FileWatch
    {

        public static ConcurrentDictionary<string,FileSystemWatcher> watchers = new ConcurrentDictionary<string,FileSystemWatcher>();

        public static string[] filters=null;
        public static bool filterEnabled = false;

        public static event FileWatchEvent.FileChangeHandle OnFileChanged;
        public static event FileWatchEvent.FileWatchSuccessDelegate OnFileWatchSuccess;
        public static event FileWatchEvent.FileWatchFaildDelegate OnFileWatchFaild;
        public static event LogEvent.ErrorLogHandle OnError;
       

        public static bool BeginMonitorPath(string path)
        {
            if (watchers.ContainsKey(path))
                return true;

            FileSystemWatcher fs = new FileSystemWatcher();
            if (File.Exists(path))
            {
                fs.Path = Path.GetDirectoryName(path);
                fs.Filter = Path.GetFileName(path);
                fs.IncludeSubdirectories = false;
            }
            else if (Directory.Exists(path))
            {
                fs.Path = path;
                fs.IncludeSubdirectories = true;
            }
            else
            {
                OnFileWatchFaild?.Invoke("path not exisit : " + path);
                return false;
            }

            if (watchers.TryAdd(path, fs))
            {
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

                OnFileWatchSuccess?.Invoke(path);
                return true;
            }
            else
            {
                fs.Dispose();
                return false;
            }
        }

        public static bool TryRemoveMonitorPath(string path)
        {
            if (watchers.IsEmpty || !watchers.ContainsKey(path))
                return true;
            FileSystemWatcher w;
            if (watchers.TryRemove(path,out w))
            {
                w.EnableRaisingEvents = false;
                w.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }


        private static void Fs_Error(object sender, ErrorEventArgs e)
        {
            OnError?.Invoke("Error found with FileWatch : ",e.GetException());
        }



        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            var fi = new FileInfo(e.FullPath);
            if (filterEnabled && null!=filters)
            {
                var ext = fi.Extension.ToLower();
                if (!filters.Contains(ext))
                    return;
            }
            OnFileChanged?.Invoke(fi);
        }

    }
}
