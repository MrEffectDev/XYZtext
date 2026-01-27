namespace xyztext
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            this.ReferenceFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRefenceFilesFoldeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreInvalidVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Entry = new System.Windows.Forms.ComboBox();
            this.RTB_Text = new FastColoredTextBoxNS.FastColoredTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileInfo = new System.Windows.Forms.Label();
            this.ValidationPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.myWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.B_SaveText.Click += new System.EventHandler(this.BSaveTextClick);
            // 
            // TB_Path
            // 
            this.TB_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Path.Location = new System.Drawing.Point(315, 28);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(307, 20);
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
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 23);
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
            this.menu_openFolder.Click += new System.EventHandler(this.OpenFolderClick);
            // 
            // importFromTXTToolStripMenuItem1
            // 
            this.importFromTXTToolStripMenuItem1.Name = "importFromTXTToolStripMenuItem1";
            this.importFromTXTToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.importFromTXTToolStripMenuItem1.Text = "Import from TXT";
            this.importFromTXTToolStripMenuItem1.Click += new System.EventHandler(this.ImportTXTClick);
            // 
            // unloadFilesToolStripMenuItem
            // 
            this.unloadFilesToolStripMenuItem.Name = "unloadFilesToolStripMenuItem";
            this.unloadFilesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.unloadFilesToolStripMenuItem.Text = "Unload files";
            this.unloadFilesToolStripMenuItem.Click += new System.EventHandler(this.UnloadFilesToolStripMenuItem_Click);
            // 
            // menu_Tools
            // 
            this.menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DumpTXT,
            this.SplitTextToolStripMenuItem,
            this.RemoveTextSplitToolStripMenuItem,
            this.trimLineToolStripMenuItem,
            this.lineInfoToolStripMenuItem,
            this.ReferenceFilesToolStripMenuItem});
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
            this.menu_DumpTXT.Click += new System.EventHandler(this.DumpTXTClick);
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
            this.trimLineToolStripMenuItem.Click += new System.EventHandler(this.TrimLineToolStripMenuItem_Click);
            // 
            // lineInfoToolStripMenuItem
            // 
            this.lineInfoToolStripMenuItem.Name = "lineInfoToolStripMenuItem";
            this.lineInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.lineInfoToolStripMenuItem.Text = "Line info";
            this.lineInfoToolStripMenuItem.Click += new System.EventHandler(this.LineInfoToolStripMenuItem_Click);
            // 
            // ReferenceFilesToolStripMenuItem
            // 
            this.ReferenceFilesToolStripMenuItem.Checked = true;
            this.ReferenceFilesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReferenceFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenRefenceFilesFoldeToolStripMenuItem,
            this.ClearReferencesToolStripMenuItem});
            this.ReferenceFilesToolStripMenuItem.Name = "ReferenceFilesToolStripMenuItem";
            this.ReferenceFilesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.ReferenceFilesToolStripMenuItem.Text = "Reference files";
            this.ReferenceFilesToolStripMenuItem.Click += new System.EventHandler(this.ReferenceFilesToolStripMenuItemClick);
            // 
            // OpenRefenceFilesFoldeToolStripMenuItem
            // 
            this.OpenRefenceFilesFoldeToolStripMenuItem.Name = "OpenRefenceFilesFoldeToolStripMenuItem";
            this.OpenRefenceFilesFoldeToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.OpenRefenceFilesFoldeToolStripMenuItem.Text = "Open reference files folder";
            this.OpenRefenceFilesFoldeToolStripMenuItem.Click += new System.EventHandler(this.OpenRefenceFilesFoldeToolStripMenuItemClick);
            // 
            // ClearReferencesToolStripMenuItem
            // 
            this.ClearReferencesToolStripMenuItem.Name = "ClearReferencesToolStripMenuItem";
            this.ClearReferencesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.ClearReferencesToolStripMenuItem.Text = "Clear references";
            this.ClearReferencesToolStripMenuItem.Click += new System.EventHandler(this.ClearReferencesToolStripMenuItemClick);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.ignoreInvalidVariablesToolStripMenuItem,
            this.gridViewToolStripMenuItem});
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
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItemClick);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.whiteToolStripMenuItem.Text = "Light";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.WhiteToolStripMenuItemClick);
            // 
            // ignoreInvalidVariablesToolStripMenuItem
            // 
            this.ignoreInvalidVariablesToolStripMenuItem.Name = "ignoreInvalidVariablesToolStripMenuItem";
            this.ignoreInvalidVariablesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.ignoreInvalidVariablesToolStripMenuItem.Text = "Ignore invalid variables";
            this.ignoreInvalidVariablesToolStripMenuItem.Click += new System.EventHandler(this.IgnoreInvalidVariablesToolStripMenuItem_Click);
            // 
            // gridViewToolStripMenuItem
            // 
            this.gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            this.gridViewToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gridViewToolStripMenuItem.Text = "Grid view";
            this.gridViewToolStripMenuItem.Click += new System.EventHandler(this.GridViewToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(61, 18);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myWebsiteToolStripMenuItem,
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
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.OpenGithubPage);
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.OpenYoutubePage);
            // 
            // supportMeToolStripMenuItem
            // 
            this.supportMeToolStripMenuItem.Name = "supportMeToolStripMenuItem";
            this.supportMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supportMeToolStripMenuItem.Text = "Support me ♡";
            this.supportMeToolStripMenuItem.Click += new System.EventHandler(this.OpenSupportPage);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // CB_Entry
            // 
            this.CB_Entry.Enabled = false;
            this.CB_Entry.FormattingEnabled = true;
            this.CB_Entry.Location = new System.Drawing.Point(106, 28);
            this.CB_Entry.Name = "CB_Entry";
            this.CB_Entry.Size = new System.Drawing.Size(203, 21);
            this.CB_Entry.TabIndex = 5;
            this.CB_Entry.SelectedIndexChanged += new System.EventHandler(this.ChangeEntry);
            // 
            // RTB_Text
            // 
            this.RTB_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Text.AutoCompleteBrackets = true;
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
            this.RTB_Text.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.RTB_Text.BackBrush = null;
            this.RTB_Text.CharHeight = 14;
            this.RTB_Text.CharWidth = 8;
            this.RTB_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTB_Text.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RTB_Text.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.RTB_Text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RTB_Text.IndentBackColor = System.Drawing.Color.Transparent;
            this.RTB_Text.IsReplaceMode = false;
            this.RTB_Text.Location = new System.Drawing.Point(0, 56);
            this.RTB_Text.Name = "RTB_Text";
            this.RTB_Text.Paddings = new System.Windows.Forms.Padding(0);
            this.RTB_Text.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.RTB_Text.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("RTB_Text.ServiceColors")));
            this.RTB_Text.Size = new System.Drawing.Size(634, 280);
            this.RTB_Text.TabIndex = 9;
            this.RTB_Text.Zoom = 100;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(634, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // fileInfo
            // 
            this.fileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileInfo.AutoSize = true;
            this.fileInfo.Location = new System.Drawing.Point(0, 350);
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Size = new System.Drawing.Size(0, 13);
            this.fileInfo.TabIndex = 10;
            // 
            // ValidationPanel
            // 
            this.ValidationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidationPanel.BackgroundImage = global::xyztext.Properties.Resources.OK;
            this.ValidationPanel.Location = new System.Drawing.Point(618, 342);
            this.ValidationPanel.Name = "ValidationPanel";
            this.ValidationPanel.Size = new System.Drawing.Size(16, 16);
            this.ValidationPanel.TabIndex = 11;
            this.ValidationPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ValidationPanelMouseClick);
            this.ValidationPanel.MouseEnter += new System.EventHandler(this.ValidationPanelMouseEnter);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // myWebsiteToolStripMenuItem
            // 
            this.myWebsiteToolStripMenuItem.Name = "myWebsiteToolStripMenuItem";
            this.myWebsiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myWebsiteToolStripMenuItem.Text = "My website";
            this.myWebsiteToolStripMenuItem.Click += new System.EventHandler(this.MyWebsiteToolStripMenuItemClick);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.ValidationPanel);
            this.Controls.Add(this.fileInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RTB_Text);
            this.Controls.Add(this.CB_Entry);
            this.Controls.Add(this.TB_Path);
            this.Controls.Add(this.B_SaveText);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.Text = "XYZtext";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem gridViewToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Label fileInfo;
        private System.Windows.Forms.Panel ValidationPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem ReferenceFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenRefenceFilesFoldeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myWebsiteToolStripMenuItem;
    }
}

