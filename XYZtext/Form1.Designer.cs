namespace xyzext
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
            this.B_SaveText = new System.Windows.Forms.Button();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_openFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DumpTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTextSplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vKTextMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Entry = new System.Windows.Forms.ComboBox();
            this.RTB_Text = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_SaveText
            // 
            this.B_SaveText.Enabled = false;
            this.B_SaveText.Location = new System.Drawing.Point(12, 26);
            this.B_SaveText.Name = "B_SaveText";
            this.B_SaveText.Size = new System.Drawing.Size(88, 24);
            this.B_SaveText.TabIndex = 2;
            this.B_SaveText.Text = "Сохранить";
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menu_Tools,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
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
            this.menu_openFolder});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // menu_openFolder
            // 
            this.menu_openFolder.Name = "menu_openFolder";
            this.menu_openFolder.Size = new System.Drawing.Size(156, 22);
            this.menu_openFolder.Text = "Открыть папку";
            this.menu_openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // menu_Tools
            // 
            this.menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DumpTXT,
            this.SplitTextToolStripMenuItem,
            this.RemoveTextSplitToolStripMenuItem});
            this.menu_Tools.Enabled = false;
            this.menu_Tools.Name = "menu_Tools";
            this.menu_Tools.Size = new System.Drawing.Size(95, 19);
            this.menu_Tools.Text = "Инструменты";
            // 
            // menu_DumpTXT
            // 
            this.menu_DumpTXT.Name = "menu_DumpTXT";
            this.menu_DumpTXT.Size = new System.Drawing.Size(248, 22);
            this.menu_DumpTXT.Text = "Dump to TXT";
            this.menu_DumpTXT.Click += new System.EventHandler(this.dumpTXT_Click);
            // 
            // SplitTextToolStripMenuItem
            // 
            this.SplitTextToolStripMenuItem.Name = "SplitTextToolStripMenuItem";
            this.SplitTextToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.SplitTextToolStripMenuItem.Text = "Автоматически разделить текст";
            this.SplitTextToolStripMenuItem.Click += new System.EventHandler(this.SplitTextToolStripMenuItem_Click);
            // 
            // RemoveTextSplitToolStripMenuItem
            // 
            this.RemoveTextSplitToolStripMenuItem.Name = "RemoveTextSplitToolStripMenuItem";
            this.RemoveTextSplitToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.RemoveTextSplitToolStripMenuItem.Text = "Убрать разделение текста";
            this.RemoveTextSplitToolStripMenuItem.Click += new System.EventHandler(this.RemoveTextSplitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vKTextMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // vKTextMeToolStripMenuItem
            // 
            this.vKTextMeToolStripMenuItem.Name = "vKTextMeToolStripMenuItem";
            this.vKTextMeToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.vKTextMeToolStripMenuItem.Text = "VK";
            this.vKTextMeToolStripMenuItem.Click += new System.EventHandler(this.vKTextMeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themeToolStripMenuItem.Text = "Тема";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Темная";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whiteToolStripMenuItem.Text = "Светлая";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
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
            this.RTB_Text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RTB_Text.Location = new System.Drawing.Point(0, 56);
            this.RTB_Text.Name = "RTB_Text";
            this.RTB_Text.Size = new System.Drawing.Size(634, 306);
            this.RTB_Text.TabIndex = 9;
            this.RTB_Text.Text = "";
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
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "XYZtext";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        public System.Windows.Forms.RichTextBox RTB_Text;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem vKTextMeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem SplitTextToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem RemoveTextSplitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menu_DumpTXT;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
    }
}

