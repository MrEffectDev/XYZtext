namespace xyztext.UI
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TB_Term;
        private System.Windows.Forms.Button B_Search;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.RadioButton RB_Forward;
        private System.Windows.Forms.RadioButton RB_Backward;
        private System.Windows.Forms.Label L_Term;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.TB_Term = new System.Windows.Forms.TextBox();
            this.B_Search = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.RB_Forward = new System.Windows.Forms.RadioButton();
            this.RB_Backward = new System.Windows.Forms.RadioButton();
            this.L_Term = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // L_Term
            // 
            this.L_Term.AutoSize = true;
            this.L_Term.Location = new System.Drawing.Point(12, 15);
            this.L_Term.Name = "L_Term";
            this.L_Term.Size = new System.Drawing.Size(52, 13);
            this.L_Term.Text = "Find what:";

            // 
            // TB_Term
            // 
            this.TB_Term.Location = new System.Drawing.Point(70, 12);
            this.TB_Term.Name = "TB_Term";
            this.TB_Term.Size = new System.Drawing.Size(180, 20);

            // 
            // RB_Forward
            // 
            this.RB_Forward.AutoSize = true;
            this.RB_Forward.Location = new System.Drawing.Point(70, 45);
            this.RB_Forward.Name = "RB_Forward";
            this.RB_Forward.Size = new System.Drawing.Size(53, 17);
            this.RB_Forward.Text = "Down";
            this.RB_Forward.Checked = true;

            // 
            // RB_Backward
            // 
            this.RB_Backward.AutoSize = true;
            this.RB_Backward.Location = new System.Drawing.Point(140, 45);
            this.RB_Backward.Name = "RB_Backward";
            this.RB_Backward.Size = new System.Drawing.Size(39, 17);
            this.RB_Backward.Text = "Up";

            // 
            // B_Search
            // 
            this.B_Search.Location = new System.Drawing.Point(260, 10);
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(75, 23);
            this.B_Search.Text = "Find Next";
            this.B_Search.UseVisualStyleBackColor = true;
            this.B_Search.Click += new System.EventHandler(this.B_Search_Click);

            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(260, 40);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(75, 23);
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);

            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 80);
            this.Controls.Add(this.L_Term);
            this.Controls.Add(this.TB_Term);
            this.Controls.Add(this.RB_Forward);
            this.Controls.Add(this.RB_Backward);
            this.Controls.Add(this.B_Search);
            this.Controls.Add(this.B_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "SearchForm";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
