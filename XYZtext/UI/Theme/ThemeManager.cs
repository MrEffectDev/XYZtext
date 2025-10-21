using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace xyztext.UI.Theme
{
    public class ThemeManager
    {
        private Font TextFont { get; } = new Font("Consolas", 10);

        public void SetTheme(ITheme theme, FormMain context)
        {
            context.BackColor = theme.ToolsPanelColor;
            context.ForeColor = theme.TextColor;

            ApplyThemeToControls(context.Controls, theme);

            context.RTB_Text.BackColor = theme.TextFieldColor;
            context.RTB_Text.ForeColor = theme.TextColor;

            ApplyThemeToDataGridView(context.dataGridView1, theme);

            if (context.RTB_Text is FastColoredTextBox fctb)
            {
                fctb.CurrentLineColor = (theme as dynamic).CurrentLineColor;
                fctb.SelectionColor = (theme as dynamic).SelectionColor;
                fctb.CaretColor = (theme as dynamic).CaretColor;
            }

            context.B_SaveText.BackColor = theme.ButtonColor;
            context.B_SaveText.ForeColor = theme.TextColor;
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, ITheme theme)
        {
            foreach (Control control in controls)
            {
                control.BackColor = theme.ToolsPanelColor;
                control.ForeColor = theme.TextColor;

                if (control is MenuStrip menu)
                {
                    menu.BackColor = theme.ToolsPanelColor;
                    menu.ForeColor = theme.TextColor;

                    foreach (ToolStripMenuItem item in menu.Items)
                        ApplyThemeToMenuItem(item, theme);
                }

                if (control.HasChildren)
                    ApplyThemeToControls(control.Controls, theme);
            }
        }

        private void ApplyThemeToMenuItem(ToolStripMenuItem item, ITheme theme)
        {
            item.BackColor = theme.ToolsPanelColor;
            item.ForeColor = theme.TextColor;

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenu)
                    ApplyThemeToMenuItem(subMenu, theme);
                else
                {
                    subItem.BackColor = theme.ToolsPanelColor;
                    subItem.ForeColor = theme.TextColor;
                }
            }
        }

        private void ApplyThemeToDataGridView(DataGridView dgv, ITheme theme)
        {
            dgv.BackgroundColor = theme.TextFieldColor;
            dgv.ForeColor = theme.TextColor;
            dgv.GridColor = theme.TextColor;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.ToolsPanelColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.TextColor;
            dgv.RowHeadersDefaultCellStyle.BackColor = theme.ToolsPanelColor;
            dgv.RowHeadersDefaultCellStyle.ForeColor = theme.TextColor;

            dgv.DefaultCellStyle.Font = TextFont;
            dgv.ColumnHeadersDefaultCellStyle.Font = TextFont;
            dgv.RowHeadersDefaultCellStyle.Font = TextFont;

            dgv.DefaultCellStyle.BackColor = theme.TextFieldColor;
            dgv.DefaultCellStyle.ForeColor = theme.TextColor;
            dgv.DefaultCellStyle.SelectionForeColor = theme.TextColor;


            dgv.RowsDefaultCellStyle.BackColor = theme.TextFieldColor;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = (theme as dynamic).AlternateRowColor;
        }

    }
}
