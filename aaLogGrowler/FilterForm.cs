using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaLogGrowler
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();

            // Configure grid
            FilterDataGridView.AutoGenerateColumns = false;

            // Select first item in each combobox
            FilterComboBox.SelectedIndex = 0;
            ActionComboBox.SelectedIndex = 0;
            ComparisonComboBox.SelectedIndex = 0;
        }

        private FilterConfiguration _filterConfig;

        public FilterConfiguration FilterConfiguration
        {
            get { return _filterConfig; }
            set
            {
                _filterConfig = value;
                //ActionColumn.DataSource = FilterConfiguration.ActionsList;
                //RelationColumn.DataSource = FilterConfiguration.RelationList;
                FilterDataGridView.DataSource = value.Rows;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _filterConfig.Reset();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _filterConfig.Rows.Add(new FilterRow());
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var row = FilterDataGridView.CurrentRow;
            if (row != null)
                _filterConfig.Rows.Remove(row.DataBoundItem as FilterRow);
        }
    }
}
