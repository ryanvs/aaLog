using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaLogGrowler
{
    public enum FilterAction
    {
        Include,
        Exclude,
    }

    public enum FilterRelation
    {
        Is,
        IsNot,
        LessThan,
        MoreThan,
        BeginsWith,
        EndsWith,
        Contains,
        Excludes,
    }


    public class FilterRow
    {
        public bool IsEnabled { get; set; }

        public string Column { get; set; }

        public FilterRelation Relation { get; set; }

        public string RelationText { get; set; }

        public string Value { get; set; }

        public FilterAction Action { get; set; }
    }
}
