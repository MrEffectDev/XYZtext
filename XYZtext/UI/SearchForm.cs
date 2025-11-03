using System;
using System.Windows.Forms;

namespace xyztext.UI
{
    public partial class SearchForm : Form
    {
        public string SearchTerm => TB_Term.Text;
        public bool SearchForward => RB_Forward.Checked;

        public event EventHandler<SearchEventArgs> SearchRequested;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void B_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_Term.Text))
            {
                MessageBox.Show("Please enter a term to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trigger an event for the main form to handle searching
            SearchRequested?.Invoke(this, new SearchEventArgs(SearchTerm, SearchForward));
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class SearchEventArgs : EventArgs
    {
        public string Term { get; }
        public bool Forward { get; }

        public SearchEventArgs(string term, bool forward)
        {
            Term = term;
            Forward = forward;
        }
    }
}
