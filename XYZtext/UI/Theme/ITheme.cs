using System.Drawing;

namespace xyztext.UI.Theme
{
    public interface ITheme
    {
        Color ToolsPanelColor { get; }
        Color TextFieldColor { get; }
        Color WindowColor { get; }
        Color TextColor { get; }
        Color ButtonColor { get; }
        Color AlternateRowColor { get; }
    }
}
