using System;
using System.Collections.Generic;

namespace aaLogGrowler
{
    public interface IUpdateStatus
    {
        void AddLogRecords(IList<aaLogReader.LogRecord> records);

        void UpdateStatus(string status, int? iterations, int? filteredCount, int? totalCount);
    }
}
