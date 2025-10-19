namespace xyztext
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B_SaveText = new System.Windows.Forms.Button();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_openFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromTXTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DumpTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTextSplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trimLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreInvalidVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Entry = new System.Windows.Forms.ComboBox();
            this.RTB_Text = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // B_SaveText
            // 
            this.B_SaveText.Enabled = false;
            this.B_SaveText.Location = new System.Drawing.Point(12, 26);
            this.B_SaveText.Name = "B_SaveText";
            this.B_SaveText.Size = new System.Drawing.Size(88, 24);
            this.B_SaveText.TabIndex = 2;
            this.B_SaveText.Text = "Save";
            this.B_SaveText.UseVisualStyleBackColor = true;
            this.B_SaveText.Click += new System.EventHandler(this.B_SaveText_Click);
            // 
            // TB_Path
            // 
            this.TB_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Path.Location = new System.Drawing.Point(191, 28);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(431, 20);
            this.TB_Path.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menu_Tools,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 22);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_openFolder,
            this.importFromTXTToolStripMenuItem1,
            this.unloadFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 18);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_openFolder
            // 
            this.menu_openFolder.Name = "menu_openFolder";
            this.menu_openFolder.Size = new System.Drawing.Size(179, 22);
            this.menu_openFolder.Text = "Open folder";
            this.menu_openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // importFromTXTToolStripMenuItem1
            // 
            this.importFromTXTToolStripMenuItem1.Name = "importFromTXTToolStripMenuItem1";
            this.importFromTXTToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.importFromTXTToolStripMenuItem1.Text = "Import from TXT";
            this.importFromTXTToolStripMenuItem1.Click += new System.EventHandler(this.ImportTXT_Click);
            // 
            // unloadFilesToolStripMenuItem
            // 
            this.unloadFilesToolStripMenuItem.Name = "unloadFilesToolStripMenuItem";
            this.unloadFilesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.unloadFilesToolStripMenuItem.Text = "Unload files";
            this.unloadFilesToolStripMenuItem.Click += new System.EventHandler(this.unloadFilesToolStripMenuItem_Click);
            // 
            // menu_Tools
            // 
            this.menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DumpTXT,
            this.SplitTextToolStripMenuItem,
            this.RemoveTextSplitToolStripMenuItem,
            this.trimLineToolStripMenuItem,
            this.lineInfoToolStripMenuItem});
            this.menu_Tools.Enabled = false;
            this.menu_Tools.Name = "menu_Tools";
            this.menu_Tools.Size = new System.Drawing.Size(54, 18);
            this.menu_Tools.Text = "Tools";
            // 
            // menu_DumpTXT
            // 
            this.menu_DumpTXT.Name = "menu_DumpTXT";
            this.menu_DumpTXT.Size = new System.Drawing.Size(242, 22);
            this.menu_DumpTXT.Text = "Export files to TXT";
            this.menu_DumpTXT.Click += new System.EventHandler(this.dumpTXT_Click);
            // 
            // SplitTextToolStripMenuItem
            // 
            this.SplitTextToolStripMenuItem.Name = "SplitTextToolStripMenuItem";
            this.SplitTextToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.SplitTextToolStripMenuItem.Text = "Automatically split text";
            this.SplitTextToolStripMenuItem.Click += new System.EventHandler(this.SplitTextToolStripMenuItem_Click);
            // 
            // RemoveTextSplitToolStripMenuItem
            // 
            this.RemoveTextSplitToolStripMenuItem.Name = "RemoveTextSplitToolStripMenuItem";
            this.RemoveTextSplitToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.RemoveTextSplitToolStripMenuItem.Text = "Remove text separation";
            this.RemoveTextSplitToolStripMenuItem.Click += new System.EventHandler(this.RemoveTextSplitToolStripMenuItem_Click);
            // 
            // trimLineToolStripMenuItem
            // 
            this.trimLineToolStripMenuItem.Name = "trimLineToolStripMenuItem";
            this.trimLineToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.trimLineToolStripMenuItem.Text = "Trim line";
            this.trimLineToolStripMenuItem.Click += new System.EventHandler(this.trimLineToolStripMenuItem_Click);
            // 
            // lineInfoToolStripMenuItem
            // 
            this.lineInfoToolStripMenuItem.Name = "lineInfoToolStripMenuItem";
            this.lineInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.lineInfoToolStripMenuItem.Text = "Line info";
            this.lineInfoToolStripMenuItem.Click += new System.EventHandler(this.lineInfoToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.ignoreInvalidVariablesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(75, 18);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.whiteToolStripMenuItem.Text = "Light";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // ignoreInvalidVariablesToolStripMenuItem
            // 
            this.ignoreInvalidVariablesToolStripMenuItem.Name = "ignoreInvalidVariablesToolStripMenuItem";
            this.ignoreInvalidVariablesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.ignoreInvalidVariablesToolStripMenuItem.Text = "Ignore invalid variables";
            this.ignoreInvalidVariablesToolStripMenuItem.Click += new System.EventHandler(this.ignoreInvalidVariablesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.youtubeToolStripMenuItem,
            this.supportMeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 18);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.OpenGithubPage);
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.OpenYoutubePage);
            // 
            // supportMeToolStripMenuItem
            // 
            this.supportMeToolStripMenuItem.Name = "supportMeToolStripMenuItem";
            this.supportMeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.supportMeToolStripMenuItem.Text = "Support me ♡";
            this.supportMeToolStripMenuItem.Click += new System.EventHandler(this.OpenSupportPage);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CB_Entry
            // 
            this.CB_Entry.Enabled = false;
            this.CB_Entry.FormattingEnabled = true;
            this.CB_Entry.Location = new System.Drawing.Point(106, 28);
            this.CB_Entry.Name = "CB_Entry";
            this.CB_Entry.Size = new System.Drawing.Size(79, 21);
            this.CB_Entry.TabIndex = 5;
            this.CB_Entry.SelectedIndexChanged += new System.EventHandler(this.changeEntry);
            // 
            // RTB_Text
            // 
            this.RTB_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Text.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.RTB_Text.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.RTB_Text.BackBrush = null;
            this.RTB_Text.CharHeight = 14;
            this.RTB_Text.CharWidth = 8;
            this.RTB_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTB_Text.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RTB_Text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RTB_Text.IsReplaceMode = false;
            this.RTB_Text.Location = new System.Drawing.Point(0, 56);
            this.RTB_Text.Name = "RTB_Text";
            this.RTB_Text.Paddings = new System.Windows.Forms.Padding(0);
            this.RTB_Text.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.RTB_Text.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("RTB_Text.ServiceColors")));
            this.RTB_Text.Size = new System.Drawing.Size(634, 306);
            this.RTB_Text.TabIndex = 9;
            this.RTB_Text.Zoom = 100;
            this.RTB_Text.AutoCompleteBrackets = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.RTB_Text);
            this.Controls.Add(this.CB_Entry);
            this.Controls.Add(this.TB_Path);
            this.Controls.Add(this.B_SaveText);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "XYZtext";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_Text)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button B_SaveText;
        public System.Windows.Forms.TextBox TB_Path;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menu_openFolder;
        public System.Windows.Forms.ToolStripMenuItem menu_Tools;
        public System.Windows.Forms.ComboBox CB_Entry;
        public FastColoredTextBoxNS.FastColoredTextBox RTB_Text;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem SplitTextToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem RemoveTextSplitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menu_DumpTXT;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem importFromTXTToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem supportMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloadFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreInvalidVariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineInfoToolStripMenuItem;
    }
}

