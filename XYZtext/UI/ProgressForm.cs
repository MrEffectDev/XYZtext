using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xyztext
{
    public partial class ProgressForm: Form
    {

        public ProgressForm()
        {
            InitializeComponent();
        }

        public void UpdateProgress(int percent, string currentFile)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgress(percent, currentFile)));
                return;
            }

            progressBar.Value = Math.Min(Math.Max(percent, 0), 100);
            statusLabel.Text = $"Exporting: {currentFile}";
        }
    }
}
