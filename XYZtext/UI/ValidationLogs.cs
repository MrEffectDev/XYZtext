using System;
using System.Drawing;
using System.Windows.Forms;
using xyztext.Utils.Validation;

namespace xyztext.UI
{
    public partial class ValidationForm : Form
    {
        private ValidationResult _results;

        public ValidationForm(ValidationResult results)
        {
            InitializeComponent();
            _results = results;

            this.Load += ValidationForm_Load;
        }

        private void ValidationForm_Load(object sender, EventArgs e)
        {
            ShowValidationResults();
        }

        public void UpdateResults(ValidationResult results)
        {
            _results = results;
            ShowValidationResults();
        }

        private void ShowValidationResults()
        {
            logs.AutoGenerateColumns = false;
            logs.AllowUserToAddRows = false;
            logs.AllowUserToDeleteRows = false;
            logs.ReadOnly = true;
            logs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            logs.MultiSelect = false;
            logs.RowHeadersVisible = false;

            logs.Columns.Clear();
            logs.Rows.Clear();

            logs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Type",
                Width = 80
            });

            logs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Line",
                HeaderText = "Line",
                Width = 60
            });

            logs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Message",
                HeaderText = "Message",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            if (_results == null)
                return;

            foreach (ValidationMessage msg in _results.Messages)
            {
                int rowIndex = logs.Rows.Add();
                DataGridViewRow row = logs.Rows[rowIndex];

                row.Cells["Type"].Value = msg.IsError ? "Error" : "Warning";
                row.Cells["Line"].Value = msg.LineIndex + 1;
                row.Cells["Message"].Value = msg.Message;

                if (msg.IsError)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkOrange;
                }
            }
        }
    }
}