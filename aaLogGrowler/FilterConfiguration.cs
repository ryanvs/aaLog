using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaLogGrowler
{
    public class FilterConfiguration
    {
        public static readonly IReadOnlyDictionary<Enum, string> RelationLookup = new Dictionary<Enum, string>
        {
            { FilterAction.Exclude, "Exclude" },
            { FilterAction.Include, "Include" },

            { FilterRelation.Is, "is" },
            { FilterRelation.IsNot, "is not" },
            { FilterRelation.LessThan, "less than" },
            { FilterRelation.MoreThan, "more than" },
            { FilterRelation.BeginsWith, "begins with" },
            { FilterRelation.EndsWith, "ends with" },
            { FilterRelation.Contains, "contains" },
            { FilterRelation.Excludes, "excludes" },
        };

        #region Combo options
        public class SimpleOptionItem<T> : ObservableObject
        {
            private string _displayValue;
            public string DisplayValue
            {
                get { return _displayValue; }
                set { SetField(ref _displayValue, value); }
            }

            private T _value;
            public T Value
            {
                get { return _value; }
                set { SetField(ref _value, value); }
            }
        }

        private static readonly BindingList<SimpleOptionItem<FilterAction>> _actionsList = GetActionsList();
        private static readonly BindingList<SimpleOptionItem<FilterRelation>> _relationList = GetRelationsList();

        public static BindingList<SimpleOptionItem<FilterAction>> ActionsList {  get { return _actionsList; } }
        public static BindingList<SimpleOptionItem<FilterRelation>> RelationList {  get { return _relationList; } }

        private static BindingList<SimpleOptionItem<FilterAction>> GetActionsList()
        {
            var result = new BindingList<SimpleOptionItem<FilterAction>>();
            result.Add(new SimpleOptionItem<FilterAction> { Value = FilterAction.Exclude, DisplayValue = "Exclude" });
            result.Add(new SimpleOptionItem<FilterAction> { Value = FilterAction.Include, DisplayValue = "Include" });
            return result;
        }

        private static BindingList<SimpleOptionItem<FilterRelation>> GetRelationsList()
        {
            var result = new BindingList<SimpleOptionItem<FilterRelation>>();
            result.Add(new SimpleOptionItem<FilterRelation> { Value = FilterRelation.Is, DisplayValue = "is" });
            result.Add(new SimpleOptionItem<FilterRelation> { Value = FilterRelation.IsNot, DisplayValue = "is not" });
            return result;
        }
        #endregion

        #region Rows
        private BindingList<FilterRow> _rows = new BindingList<FilterRow>();
        public BindingList<FilterRow> Rows
        {
            get { return _rows; }
        }

        public void Add(FilterRow row)
        {
            _rows.Add(row);
        }

        public void Reset()
        {
            _rows.Clear();
            var defaultRows = new FilterRow[]
            {
                new FilterRow() { Action= FilterAction.Include, Column="Log Flag", Relation = FilterRelation.Is, RelationText = "is", Value = "Error" },
            };
            foreach (var row in defaultRows)
            {
                _rows.Add(row);
            }
        }
        #endregion
    }
}
