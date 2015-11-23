using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaLogGrowler
{
    public partial class MainForm : Form, IUpdateStatus
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private BindingList<aaLogReader.LogRecord> _logRecords = new BindingList<aaLogReader.LogRecord>();
        private Task _monitorTask = Task.FromResult(0);

        //private FilterConfiguration _filterConfig;
        private MonitorLogger _logMonitor;

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            ConfigureToolStrip();
            ConfigureLogMonitor();
            ConfigureDataGridView();
        }
        #endregion

        #region Form Events
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMonitorLogging(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartMonitorLogging();
        }
        #endregion

        #region Configuration
        private void ConfigureDataGridView()
        {
            MainDataGridView.AutoGenerateColumns = false;
            MainDataGridView.DataSource = _logRecords;
        }

        private void ConfigureLogMonitor()
        {
            //_filterConfig = new FilterConfiguration();
            _logMonitor = new MonitorLogger(this);
        }

        private void ConfigureToolStrip()
        {
            MainToolStrip.ImageList = MainImageList;
            OpenToolStripButton.ImageKey = "open";
            SaveToolStripButton.ImageKey = "save";
            FilterToolStripButton.ImageKey = "filter";
        }
        #endregion

        #region Monitor Logging
        public bool IsMonitorLogging
        {
            get { return (!_monitorTask.IsCompleted && !_monitorTask.IsCanceled && !_monitorTask.IsFaulted) ; }
        }

        private void StartMonitorLogging()
        {
            bool isRunning = IsMonitorLogging;
            log.DebugFormat("StartMonitorLogging: IsRunning={0}", isRunning);
            if (!isRunning)
            {
                StatusLabel.Text = "Monitoring...";
                _monitorTask = Task.Run((Action)RunMonitor)
                                   .ContinueWith(AfterMonitor);
                monitorLoggingToolStripMenuItem.Checked = true;
            }
        }

        public void AddLogRecords(IList<aaLogReader.LogRecord> records)
        {
            if (IsDisposed) return;
            if (InvokeRequired)
            {
                BeginInvoke((Action)delegate { AddLogRecords(records); });
                return;
            }

            foreach (var item in records.Reverse())
            {
                _logRecords.Add(item);
                GrowlHelper.simpleGrowl(item.Component, item.Message);
            }
        }

        public void UpdateStatus(string status, int? iterations = null, int? filteredCount = null, int? totalCount = null)
        {
            if (IsDisposed) { return; }
            if (InvokeRequired)
            {
                BeginInvoke((Action)delegate { UpdateStatus(status, iterations, filteredCount, totalCount); });
                return;
            }

            if (status != null)
                StatusLabel.Text = status;
            if (iterations != null)
                IterationCountLabel.Text = string.Format("Iterations: {0}", iterations);
            if (filteredCount != null)
                FilteredEventCountLabel.Text = string.Format("Filtered Events: {0}", filteredCount);
            if (iterations != null)
                TotalEventCountLabel.Text = string.Format("Total Events: {0}", totalCount);
            monitorLoggingToolStripMenuItem.Checked = IsMonitorLogging;
        }

        private void RunMonitor()
        {
            _logMonitor.Run();
        }

        private int AfterMonitor(Task prevTask)
        {
            if (prevTask.IsCanceled)
            {
                UpdateStatus("Monitoring canceled");
                return -1;
            }
            if (prevTask.IsFaulted)
            {
                var ex = prevTask.Exception;
                string msg = string.Join("; ", ex.InnerExceptions.Select(x => x.Message));
                StatusLabel.Text = msg;
                UpdateStatus("Exception: " + msg);
                return -1;
            }
            if (prevTask.IsCompleted)
            {
                UpdateStatus("Monitoring stopped");
            }
            return 0;
        }

        private void StopMonitorLogging(bool waitForExit = false)
        {
            StatusLabel.Text = "Stopping...";
            monitorLoggingToolStripMenuItem.Checked = false;

            if (IsMonitorLogging)
                _logMonitor.Cancel();
            if (waitForExit)
                _monitorTask.Wait();
        }

        private void ToggleMonitorLogging()
        {
            if (IsMonitorLogging)
                StopMonitorLogging();
            else
                StartMonitorLogging();
        }
        #endregion

        private void FilterToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new FilterForm())
            {
                f.FilterConfiguration = _logMonitor.FilterConfiguration;
                f.ShowDialog(this);
            }
        }

        private void monitorLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleMonitorLogging();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void findHighlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void findBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void autoScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void clearDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _logRecords.Clear();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void toggleBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void filterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //
        }

        private void resetFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
