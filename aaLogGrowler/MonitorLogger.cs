using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aaLogGrowler
{
    public class MonitorLogger
    {
        #region Properties
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private CancellationTokenSource _cancelToken = new CancellationTokenSource();
        private TimeSpan _waitTimeSpan = TimeSpan.FromSeconds(1.0);
        private Stopwatch _totalTime;
        #endregion

        #region Constructors
        private MonitorLogger()
        { }

        public MonitorLogger(IUpdateStatus updateStatus)
        {
            _updateStatus = updateStatus;
            _filterConfig = new FilterConfiguration();
            _filterConfig.Reset();
        }
        #endregion

        #region Counters
        private object _syncRoot = new object();
        private int _iterationCount;
        private int _filteredCount;
        private int _totalCount;

        public object SyncRoot
        {
            get { return _syncRoot; }
        }

        public int IterationCount
        {
            get { return _iterationCount; }
        }

        public int FilteredCount
        {
            get { return _filteredCount; }
        }

        public int TotalCount
        {
            get { return _totalCount; }
        }

        public void ResetCounters()
        {
            _iterationCount = 0;
            _filteredCount = 0;
            _totalCount = 0;
        }
        #endregion

        #region Notifications Callback
        private IUpdateStatus _updateStatus;

        private void AddLogRecords(IList<aaLogReader.LogRecord> records)
        {
            // TODO: Apply filters
            if (_updateStatus != null)
                _updateStatus.AddLogRecords(records);
        }

        private void UpdateStatus(string status)
        {
            if (_updateStatus != null)
                _updateStatus.UpdateStatus(status, _iterationCount, _filteredCount, _totalCount);
        }
        #endregion

        #region LogReader and Options
        private aaLogReader.OptionsStruct _logReaderOptions = new aaLogReader.OptionsStruct()
        {
            IgnoreCacheFileOnFirstRead = true,
        };

        public aaLogReader.OptionsStruct LogReaderOptions
        {
            get { return _logReaderOptions; }
        }

        private aaLogReader.aaLogReader _logReader;

        public aaLogReader.aaLogReader LogReader
        {
            get { return _logReader; }
        }
        #endregion

        #region Filter Configuration
        private FilterConfiguration _filterConfig;
        public FilterConfiguration FilterConfiguration
        {
            get { return _filterConfig; }
        }
        #endregion

        #region Monitor Loop and Cancellation
        public CancellationToken CancelToken
        {
            get { return _cancelToken.Token; }
        }

        public bool IsCancellationRequested
        {
            get { return _cancelToken.IsCancellationRequested; }
        }

        public TimeSpan LoopCycleTime
        {
            get { return _waitTimeSpan; }
            set
            {
                if (value < TimeSpan.Zero)
                    value = TimeSpan.Zero;
                _waitTimeSpan = value;
            }
        }

        public TimeSpan TotalElapsedTime
        {
            get { return _totalTime.Elapsed; }
        }

        public void Cancel()
        {
            _cancelToken.Cancel();
        }

        public void Run()
        {
            ulong readCount = 0;
            _totalTime = Stopwatch.StartNew();

            // Reset the cancel token
            if (_cancelToken.IsCancellationRequested)
                _cancelToken = new CancellationTokenSource();

            // Create the reader and start the loop
            _log.Info("Run: Creating aaLogReader");
            using (_logReader = new aaLogReader.aaLogReader(_logReaderOptions))
            {
                TimeSpan loopTime = TimeSpan.Zero;
                TimeSpan waitTime = _waitTimeSpan;

                _log.Info("Run: Starting monitor loop");
                while (_cancelToken.Token.WaitHandle.WaitOne(waitTime, false) == false)
                {
                    ++_iterationCount;
                    var loopWatch = Stopwatch.StartNew();
                    var records = _logReader.GetUnreadRecords(readCount, "", false);
                    _cancelToken.Token.ThrowIfCancellationRequested();
                    if (records.Count > 0)
                    {
                        AddLogRecords(records);
                        _totalCount += records.Count;
                    }

                    // Update the status bar
                    _cancelToken.Token.ThrowIfCancellationRequested();
                    UpdateStatus(null);

                    // Calculate wait time
                    _cancelToken.Token.ThrowIfCancellationRequested();
                    loopWatch.Stop();
                    _log.DebugFormat("Run: Iterations={0}, Count={1}, LoopTime={2}", _iterationCount, _totalCount, loopWatch.Elapsed);
                    readCount = 100;
                    waitTime = _waitTimeSpan - loopWatch.Elapsed;
                    if (waitTime < TimeSpan.Zero) { waitTime = TimeSpan.Zero; }
                }
            }

            _totalTime.Stop();
            _log.InfoFormat("Run: Iterations={0}, Count={1}, TotalTime={2}", _iterationCount, _totalCount, _totalTime.Elapsed);
        }
        #endregion
    }
}
