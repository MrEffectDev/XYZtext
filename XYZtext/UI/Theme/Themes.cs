using System.Drawing;

namespace xyztext.UI.Theme
{
    public class Themes
    {
        public class Dark : ITheme
        {
            public Color ToolsPanelColor { get; } = Color.FromArgb(26, 33, 42);
            public Color TextFieldColor { get; } = Color.FromArgb(39, 39, 39);
            public Color WindowColor { get; } = Color.FromArgb(0, 11, 30);
            public Color TextColor { get; } = Color.White;
            public Color ButtonColor { get; } = Color.FromArgb(39, 46, 54);

            public Color CurrentLineColor { get; } = Color.FromArgb(50, 50, 50);
            public Color SelectionColor { get; } = Color.FromArgb(70, 130, 180, 50);
            public Color CaretColor { get; } = Color.White;

            public Color AlternateRowColor { get; } = Color.FromArgb(50, 50, 50);
        }

        public class White : ITheme
        {
            public Color ToolsPanelColor { get; } = Color.FromArgb(240, 240, 240);
            public Color TextFieldColor { get; } = Color.FromArgb(255, 255, 255);
            public Color WindowColor { get; } = Color.FromArgb(241, 243, 249);
            public Color TextColor { get; } = Color.Black;
            public Color ButtonColor { get; } = Color.FromArgb(253, 253, 253);

            public Color CurrentLineColor { get; } = Color.FromArgb(230, 240, 255);
            public Color SelectionColor { get; } = Color.FromArgb(100, 173, 216, 230);
            public Color CaretColor { get; } = Color.Black;

            public Color AlternateRowColor { get; } = Color.FromArgb(245, 245, 245);
        }
    }
}
