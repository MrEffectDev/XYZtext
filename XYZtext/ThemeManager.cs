using xyzext;

namespace xyztext
{
    public class ThemeManager
    {
        public void SetTheme(Theme theme, Form1 context)
        {
            context.B_SaveText.BackColor = theme.ButtonColor;
            context.B_SaveText.ForeColor = theme.TextColor;
            context.RTB_Text.BackColor = theme.TextFieldColor;
            context.RTB_Text.ForeColor = theme.TextColor;
            context.menuStrip1.BackColor = theme.ToolsPanelColor;
            context.menuStrip1.ForeColor = theme.TextColor;
            context.fileToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.fileToolStripMenuItem.ForeColor = theme.TextColor;
            context.menu_openFolder.BackColor = theme.ToolsPanelColor;
            context.menu_openFolder.ForeColor = theme.TextColor;
            context.menu_Tools.BackColor = theme.ToolsPanelColor;
            context.menu_Tools.ForeColor = theme.TextColor;
            context.TB_Path.BackColor = theme.ToolsPanelColor;
            context.TB_Path.ForeColor = theme.TextColor;

            context.helpToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.helpToolStripMenuItem.ForeColor = theme.TextColor;
            context.vKTextMeToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.vKTextMeToolStripMenuItem.ForeColor = theme.TextColor;
            context.SplitTextToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.SplitTextToolStripMenuItem.ForeColor = theme.TextColor;
            context.RemoveTextSplitToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.RemoveTextSplitToolStripMenuItem.ForeColor = theme.TextColor;
            context.menu_DumpTXT.BackColor = theme.ToolsPanelColor;
            context.menu_DumpTXT.ForeColor = theme.TextColor;
            context.settingsToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.settingsToolStripMenuItem.ForeColor = theme.TextColor;
            context.themeToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.themeToolStripMenuItem.ForeColor = theme.TextColor;
            context.darkToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.darkToolStripMenuItem.ForeColor = theme.TextColor;
            context.whiteToolStripMenuItem.BackColor = theme.ToolsPanelColor;
            context.whiteToolStripMenuItem.ForeColor = theme.TextColor;
            context.importFromTXTToolStripMenuItem1.BackColor = theme.ToolsPanelColor; 
            context.importFromTXTToolStripMenuItem1.ForeColor = theme.TextColor; 

            context.CB_Entry.BackColor = theme.ToolsPanelColor;
            context.CB_Entry.ForeColor = theme.TextColor;

            context.ForeColor = theme.TextColor;
            context.BackColor = theme.ToolsPanelColor;
        }
    }
}
