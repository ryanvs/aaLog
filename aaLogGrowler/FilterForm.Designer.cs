namespace aaLogGrowler
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.PreviousFiltersLabel = new System.Windows.Forms.Label();
            this.DisplayEntriesLabel = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.ComparisonComboBox = new System.Windows.Forms.ComboBox();
            this.ValueCcomboBox = new System.Windows.Forms.ComboBox();
            this.ThenLabel = new System.Windows.Forms.Label();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FilterDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelFormButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.FilterImageList = new System.Windows.Forms.ImageList(this.components);
            this.IsEnabledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FilterNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilterDataGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviousFiltersLabel
            // 
            this.PreviousFiltersLabel.AutoSize = true;
            this.PreviousFiltersLabel.Location = new System.Drawing.Point(3, 0);
            this.PreviousFiltersLabel.Name = "PreviousFiltersLabel";
            this.PreviousFiltersLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PreviousFiltersLabel.Size = new System.Drawing.Size(379, 22);
            this.PreviousFiltersLabel.TabIndex = 0;
            this.PreviousFiltersLabel.Text = "Filters were in effect the last time you exited aaLogGrowler:";
            // 
            // DisplayEntriesLabel
            // 
            this.DisplayEntriesLabel.AutoSize = true;
            this.DisplayEntriesLabel.Location = new System.Drawing.Point(3, 22);
            this.DisplayEntriesLabel.Name = "DisplayEntriesLabel";
            this.DisplayEntriesLabel.Size = new System.Drawing.Size(273, 17);
            this.DisplayEntriesLabel.TabIndex = 1;
            this.DisplayEntriesLabel.Text = "Display entries matching these conditions:";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Date",
            "Time",
            "Date and Time",
            "Process ID",
            "Thread ID",
            "Log Flag",
            "Component",
            "Message"});
            this.FilterComboBox.Location = new System.Drawing.Point(3, 3);
            this.FilterComboBox.MaxDropDownItems = 20;
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(92, 24);
            this.FilterComboBox.TabIndex = 2;
            // 
            // ComparisonComboBox
            // 
            this.ComparisonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComparisonComboBox.FormattingEnabled = true;
            this.ComparisonComboBox.Items.AddRange(new object[] {
            "is",
            "is not",
            "less than",
            "more than",
            "begins with",
            "ends with",
            "contains",
            "excludes"});
            this.ComparisonComboBox.Location = new System.Drawing.Point(101, 3);
            this.ComparisonComboBox.Name = "ComparisonComboBox";
            this.ComparisonComboBox.Size = new System.Drawing.Size(95, 24);
            this.ComparisonComboBox.TabIndex = 3;
            // 
            // ValueCcomboBox
            // 
            this.ValueCcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueCcomboBox.FormattingEnabled = true;
            this.ValueCcomboBox.Location = new System.Drawing.Point(202, 3);
            this.ValueCcomboBox.Name = "ValueCcomboBox";
            this.ValueCcomboBox.Size = new System.Drawing.Size(419, 24);
            this.ValueCcomboBox.TabIndex = 4;
            // 
            // ThenLabel
            // 
            this.ThenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThenLabel.AutoSize = true;
            this.ThenLabel.Location = new System.Drawing.Point(627, 6);
            this.ThenLabel.Name = "ThenLabel";
            this.ThenLabel.Size = new System.Drawing.Size(36, 17);
            this.ThenLabel.TabIndex = 5;
            this.ThenLabel.Text = "then";
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Items.AddRange(new object[] {
            "Include",
            "Exclude"});
            this.ActionComboBox.Location = new System.Drawing.Point(669, 3);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(80, 24);
            this.ActionComboBox.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PreviousFiltersLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DisplayEntriesLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FilterDataGridView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.FilterComboBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ActionComboBox, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComparisonComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ThenLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ValueCcomboBox, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(752, 30);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.RemoveButton, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(752, 32);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(3, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 26);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(583, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 26);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(669, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(80, 26);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "&Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FilterDataGridView
            // 
            this.FilterDataGridView.AllowUserToAddRows = false;
            this.FilterDataGridView.AllowUserToResizeRows = false;
            this.FilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsEnabledColumn,
            this.FilterNameColumn,
            this.RelationColumn,
            this.ValueColumn,
            this.ActionColumn});
            this.FilterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterDataGridView.Location = new System.Drawing.Point(3, 116);
            this.FilterDataGridView.Name = "FilterDataGridView";
            this.FilterDataGridView.RowTemplate.Height = 24;
            this.FilterDataGridView.Size = new System.Drawing.Size(752, 380);
            this.FilterDataGridView.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.OkButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.CancelFormButton, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.ApplyButton, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 499);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(758, 32);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(503, 3);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(80, 26);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "&OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.CausesValidation = false;
            this.CancelFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFormButton.Location = new System.Drawing.Point(589, 3);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(80, 26);
            this.CancelFormButton.TabIndex = 1;
            this.CancelFormButton.Text = "Cancel";
            this.CancelFormButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(675, 3);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(80, 26);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "&Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // FilterImageList
            // 
            this.FilterImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FilterImageList.ImageStream")));
            this.FilterImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FilterImageList.Images.SetKeyName(0, "Include");
            this.FilterImageList.Images.SetKeyName(1, "Exclude");
            // 
            // IsEnabledColumn
            // 
            this.IsEnabledColumn.DataPropertyName = "IsEnabled";
            this.IsEnabledColumn.HeaderText = "";
            this.IsEnabledColumn.Name = "IsEnabledColumn";
            this.IsEnabledColumn.ToolTipText = "Is Enabled";
            // 
            // FilterNameColumn
            // 
            this.FilterNameColumn.DataPropertyName = "Column";
            this.FilterNameColumn.HeaderText = "Column";
            this.FilterNameColumn.Name = "FilterNameColumn";
            this.FilterNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FilterNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RelationColumn
            // 
            this.RelationColumn.DataPropertyName = "Relation";
            this.RelationColumn.HeaderText = "Relation";
            this.RelationColumn.Name = "RelationColumn";
            this.RelationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RelationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValueColumn
            // 
            this.ValueColumn.DataPropertyName = "Value";
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            // 
            // ActionColumn
            // 
            this.ActionColumn.DataPropertyName = "Action";
            this.ActionColumn.HeaderText = "Action";
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelFormButton;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "FilterForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "aaLogGrowler Filter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilterDataGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PreviousFiltersLabel;
        private System.Windows.Forms.Label DisplayEntriesLabel;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.ComboBox ComparisonComboBox;
        private System.Windows.Forms.ComboBox ValueCcomboBox;
        private System.Windows.Forms.Label ThenLabel;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.DataGridView FilterDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelFormButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.ImageList FilterImageList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEnabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilterNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionColumn;
    }
}