using System.Drawing;

namespace xyztext
{
    public class Themes
    {
        public class Dark : Theme
        {
            public Color ToolsPanelColor { get; } = Color.FromArgb(26, 33, 42);
            public Color TextFieldColor { get; } = Color.FromArgb(39, 39, 39);
            public Color WindowColor { get; } = Color.FromArgb(0, 11, 30);
            public Color TextColor { get; } = Color.White;
            public Color ButtonColor { get; } = Color.FromArgb(39, 46, 54);
        }

        public class White : Theme
        {
            public Color ToolsPanelColor { get; } = Color.FromArgb(240, 240, 240);
            public Color TextFieldColor { get; } = Color.FromArgb(255, 255, 255);
            public Color WindowColor { get; } = Color.FromArgb(241, 243, 249);
            public Color TextColor { get; } = Color.Black;
            public Color ButtonColor { get; } = Color.FromArgb(253, 253, 253);
        }
    }
    
}
