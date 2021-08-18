using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
using WorkermanDev.Event;
using System.Drawing;
using System.IO;

namespace WorkermanDev.Lib
{
    class ConfigFile
    {

        static FileIniDataParser parser;
        static IniData data;
        static readonly string path = "Config.ini";

        public static event LogEvent.ErrorLogHandle OnConfigFileError;
        public static event LogEvent.CommonLogHandle OnConfigFileWarn;

        public static void Init()
        {
            parser = new FileIniDataParser();
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    OnConfigFileWarn?.Invoke("your config file are not found and an empty one has been created!");
                }
                data = parser.ReadFile(path);
            }catch(Exception e)
            {
                OnConfigFileError?.Invoke("Can not read config file, please fix the problem and restart, error:" , e);
            }

        }

        public static string GetValue(string key, string section = "main")
        {
            string ret= data[section][key];
            return ret;
        }

        public static void SetValue(string key, string v, string section = "main")
        {
            data[section][key] = v;
            Save();
        }

        static void Save()
        {
            try
            {
                parser.WriteFile(path, data);
            }catch(Exception e)
            {
                OnConfigFileError.Invoke("Can not save your configs ,the change will be lost.", e);
            }
            
        }
    }
}
