using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkermanDev.Event
{
    class FileWatchEvent
    {
        public delegate void FileChangeHandle(FileInfo fi);

        public delegate void FileWatchSuccessDelegate(string path);

        public delegate void FileWatchFaildDelegate(string path);
    }
}
