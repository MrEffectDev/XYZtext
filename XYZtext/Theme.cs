using System.Drawing;

namespace xyztext
{
    public interface Theme
    {
        Color ToolsPanelColor { get; }
        Color TextFieldColor { get; }
        Color WindowColor { get; }
        Color TextColor { get; }
        Color ButtonColor { get; }
    }
}
