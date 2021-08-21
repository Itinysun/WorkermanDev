using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using WorkermanDev.Event;
using WorkermanDev.Lib;


namespace WorkermanDev
{
    // 1.定义委托



    public partial class Form1 : Form
    {
        private static bool taskEnable = false;
        private delegate void SwitchProcessStateHandel(bool enabled);

        public Form1()
        {
            InitializeComponent();

            LogWriter.OnLogWrite += LogWriter_OnLogWrite;

            ExceptionWriter.OnExceptionSaveError += ExceptionWriter_OnExceptionSaveError;

            LogWriter.BeginProcessEvent();

            ConfigFile.Init();

            FileWatch.OnFileChanged += FileWatch_OnFileChanged;

            InitDebounce();
            numericUpDownDebounce.ValueChanged += numericUpDownDebounce_ValueChanged;

            InitMonitor();

            InitFilter();

            InitMainProcess();

            MainProcess.OnProcessStart += MainProcess_OnProcessStart;
            MainProcess.OnProcessEnd += MainProcess_OnProcessEnd;
        }


        private void TbStart_Click(object sender, EventArgs e)
        {
            MainProcess.Start();
        }

        private void TbStop_Click(object sender, EventArgs e)
        {
            MainProcess.Stop();
        }


        private void MainProcess_OnProcessEnd(Process p)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SwitchProcessStateHandel(SwitchProcessState), false);
            }
            else
            {
                SwitchProcessState(false);
            }
        }

        private void MainProcess_OnProcessStart(Process p)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SwitchProcessStateHandel(SwitchProcessState), true);
            }
            else
            {
                SwitchProcessState(true);
            }
        }

        private void SwitchProcessState(bool enabled)
        {
            TbStart.Enabled = !enabled;
            TbRestart.Enabled= enabled;
            TbStop.Enabled = enabled;
            taskEnable = enabled;
        }

        private void ExceptionWriter_OnExceptionSaveError(string content)
        {
            MessageBox.Show("Error! Can't save exception to file!", content, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void FileWatch_OnFileChanged(FileInfo fi)
        {
            if (taskEnable)
            {
                MainProcess.Restart();
            }
        }

        private void InitMainProcess()
        {
            MainProcess.Clear();
            var errors = "";
            string php = ConfigFile.GetValue("php-path");
            if (string.IsNullOrEmpty(php))
            {
                errors += " [php path] ";
            }
            string start = ConfigFile.GetValue("start-path");
            if (string.IsNullOrEmpty(start))
            {
                errors += " [start path] ";
            }
            if (string.IsNullOrEmpty(errors))
            {
                textBoxStart.Text = start;
                textBoxPhp.Text = php;
                MainProcess.Init(php, start);
            }
            else
            {
                LogWriter.WriteErrorLog("You have to finish config first!", new Exception("Please set :"+errors));
            }
        }

        private void InitFilter()
        {
            string filters = ConfigFile.GetValue("filters");
            string filters_enable = ConfigFile.GetValue("filters-enable");
            if (!string.IsNullOrEmpty(filters))
            {
                FileWatch.filters = filters.Split('|');
                TbFilter.Text = filters;
            }
            if (!string.IsNullOrEmpty(filters_enable) || filters_enable=="1")
            {
                FileWatch.filterEnabled = true;
            }
            else
            {
                FileWatch.filterEnabled = false;
            }
            CbFilter.Checked = FileWatch.filterEnabled;

        }

        private void InitMonitor()
        {
            string m = ConfigFile.GetValue("monitors");
            
            if (!string.IsNullOrEmpty(m))
            {
                var ms =  m.Split('|');
                foreach(var s in ms)
                {
                    listBoxMonitor.Items.Add(s);
                    FileWatch.BeginMonitorPath(s);
                }
            }
        }

        #region logBox
        private void LogWriter_OnLogWrite(LogEvent.LogWriteEventArgs e)
        {
            if (LogBox.InvokeRequired)
            {
                this.Invoke(new LogEvent.LogHandle(WriteToRichText), e);
            }
            else
            {
                WriteToRichText(e);
            }
        }

        private void WriteToRichText(LogEvent.LogWriteEventArgs e)
        {
            if (e.cleanScreen)
            {
                LogBox.Clear();
            }
            LogBox.Select(LogBox.TextLength, 0);
            LogBox.SelectionColor = e.color;
            LogBox.AppendText(DateTime.Now.ToString("[hh:mm:ss] ") + e.content + Environment.NewLine);
            LogBox.Select(LogBox.TextLength, 0);
            LogBox.ScrollToCaret();
        }

        private void LogBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
        #endregion

        #region config
        private void InitDebounce()
        {
            string t = ConfigFile.GetValue("debounce");
            if (string.IsNullOrEmpty(t))
            {
                t = "2";
            }
            int real_time = 0;
            if(!int.TryParse(t,out real_time))
            {
                real_time = 2;
            }
            numericUpDownDebounce.Value = real_time;
            MainProcess.SetDeBounce(real_time);
        }

        private void buttonSelectPhp_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.Title = "Please select php.exe for workerman runtime";
            op.Filter = "php.exe|php.exe";
            if(op.ShowDialog() == DialogResult.OK)
            {
                setPhpPath(op.FileName);
            }
        }
        private void setPhpPath(string path)
        {
            textBoxPhp.Text = path;
            ConfigFile.SetValue("php-path", path);
            InitMainProcess();
        }

        private void buttonStartpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.Title = "Please select bootstap file";
            op.Filter = "php|*.php";
            if (op.ShowDialog() == DialogResult.OK)
            {
                setStartPath(op.FileName);
            }
        }
        private void setStartPath(string path)
        {
            textBoxStart.Text = path;
            ConfigFile.SetValue("start-path", path);
            InitMainProcess();
        }

        private void File_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void textBoxPhp_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string p = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                FileInfo fi = new FileInfo(p);
                if(fi.Extension.ToLower().Equals(".exe") && fi.Name.ToLower().Equals("php"))
                {
                    setPhpPath(p);
                }
                else
                {
                    throw new Exception("error");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Please select php.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBoxStart_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string p = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                FileInfo fi = new FileInfo(p);
                if (fi.Extension.ToLower().Equals(".php"))
                {
                    setStartPath(p);
                }
                else
                {
                    throw new Exception("error");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Please select a php file(*.php)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownDebounce_ValueChanged(object sender, EventArgs e)
        {
            var d = (int)numericUpDownDebounce.Value;
            MainProcess.SetDeBounce(d);
            ConfigFile.SetValue("debounce", d.ToString());
        }
        #endregion

        #region monitors
        private void TsbAddMonitor_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            op.Title = "Please select files";
            string start = ConfigFile.GetValue("start-path");
            if (null != start)
            {
                op.InitialDirectory = Path.GetDirectoryName(start);
            }
            
            if (op.ShowDialog() == DialogResult.OK)
            {
                AddMonitorPath(op.FileNames);
            }
        }

        private void TsbAddMonitorFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowNewFolderButton = false;
            fb.RootFolder = Environment.SpecialFolder.MyComputer;
            string start = ConfigFile.GetValue("start-path");
            if (null != start)
            {
                fb.SelectedPath = Path.GetDirectoryName(start);
            }
            if (fb.ShowDialog() == DialogResult.OK)
            {
                AddMonitorPath(new string[] { fb.SelectedPath });
            }
        }

        private void AddMonitorPath(string[] filenames)
        {
            foreach(var fn in filenames)
            {
                if (!listBoxMonitor.Items.Contains(fn) && FileWatch.BeginMonitorPath(fn))
                {
                     listBoxMonitor.Items.Add(fn);
                }
            }
            ConfigFile.UpdateWatchersAndFilters();
        }

        private void TsbDeleteMonitor_Click(object sender, EventArgs e)
        {
            var selects = listBoxMonitor.SelectedItems;
            if (selects.Count == 1)
            {
                var s = selects[0];
                if (FileWatch.TryRemoveMonitorPath(s.ToString()))
                {
                    listBoxMonitor.Items.Remove(s);
                }
                ConfigFile.UpdateWatchersAndFilters();
            }

        }

        private void CbFilter_CheckStateChanged(object sender, EventArgs e)
        {
            TbFilter.Enabled = CbFilter.Checked;
            BtConfirmFilter.Enabled = CbFilter.Checked;
            ConfigFile.UpdateWatchersAndFilters();
        }

        #endregion

        #region filters

        private void BtConfirmFilter_Click(object sender, EventArgs e)
        {
            FileWatch.filters = TbFilter.Text.Split('|');
            ConfigFile.UpdateWatchersAndFilters();
        }

        private void TbRestart_Click(object sender, EventArgs e)
        {
            TbStart.Enabled = false;
            TbStop.Enabled = false;
            TbRestart.Enabled = false;
            MainProcess.Restart();
        }

        #endregion


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProcess.OnProcessEnd -= MainProcess_OnProcessEnd;
            MainProcess.Stop();
        }
    }
}
