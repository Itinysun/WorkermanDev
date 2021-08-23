using System;
using System.Collections.Generic;
using System.IO;
using WorkermanDev.Event;

namespace WorkermanDev.Lib
{
    class ConfigFile
    {

        static IniFile parser;
        static readonly string path = "Config.ini";

        public static event LogEvent.ErrorLogHandle OnConfigFileError;
        public static event LogEvent.CommonLogHandle OnConfigFileWarn;
        public static event LogEvent.CommonLogHandle OnConfigFileSuccess;

        public static void Init()
        {
            parser = new IniFile();
            try
            {
                if (!File.Exists(path))
                {
                    parser.Save(path);
                    OnConfigFileWarn?.Invoke("your config file are not found and an empty one has been created!");
                }
                parser.Load(path);
            }catch(Exception e)
            {
                OnConfigFileError?.Invoke("Can not read config file, please fix the problem and restart, error:" , e);
            }

        }

        public static string GetValue(string key, string section = "main")
        {
            return parser[section][key].GetString();
        }

        public static void SetValue(string key, string v, string section = "main")
        {
            parser[section][key] = v;
            Save();
        }

        static readonly DebounceDispatcher debounceSave = new DebounceDispatcher(2000);

        static void Save()
        {
            try
            {
                debounceSave.Debounce(() =>
                {
                    parser.Save(path);
                    OnConfigFileSuccess?.Invoke("Config update successful!");
                });

            }
            catch(Exception e)
            {
                OnConfigFileError.Invoke("Can not save your configs ,the change will be lost.", e);
            }
        }

        static DebounceDispatcher debounceUpdate = new DebounceDispatcher(2000);
        public static void UpdateWatchersAndFilters()
        {
            debounceUpdate.Debounce(() =>
            {
                List<string> ws = new List<string>();
                foreach(var w in FileWatch.watchers)
                {
                    ws.Add(w.Key);
                }
                SetValue("monitors", String.Join("|", ws));

                SetValue("filters-enable", FileWatch.filterEnabled ? "1" : "0");

                if (null != FileWatch.filters)
                    SetValue("filters", String.Join("|", FileWatch.filters));
            });
        }
    }
}
