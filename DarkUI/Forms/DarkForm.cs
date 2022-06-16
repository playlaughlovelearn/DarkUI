using DarkUI.Config;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DarkUI.Forms
{
    public class DarkForm : Form
    {
        #region Field Region

        private bool _flatBorder;

        #endregion

        #region Property Region

        [Category("Appearance")]
        [Description("Determines whether a single pixel border should be rendered around the form.")]
        [DefaultValue(false)]
        public bool FlatBorder
        {
            get { return _flatBorder; }
            set
            {
                _flatBorder = value;
                Invalidate();
            }
        }

        public enum Themes { DarkTheme, LightTheme };
        private Themes m_Theme = Themes.DarkTheme;

        public Themes Theme
        {
            get { return m_Theme; }
            set {
                m_Theme = value;
                if (m_Theme == Themes.DarkTheme)
                    ThemeProvider.Theme = new DarkTheme();
                else
                    ThemeProvider.Theme = new LightTheme();
            }
        }

        #endregion

        #region Constructor Region

        public DarkForm()
        {
            ThemeProvider.ThemeChanged += ThemeProvider_ThemeChanged;
            BackColor = ThemeProvider.Theme.Colors.GreyBackground;
        }

        private void ThemeProvider_ThemeChanged()
        {
            BackColor = ThemeProvider.Theme.Colors.GreyBackground;
            Invalidate();
            System.Console.WriteLine("Theme Changed: " + Theme.ToString());
        }

        #endregion

        #region Paint Region

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (!_flatBorder)
                return;

            var g = e.Graphics;

            using (var p = new Pen(ThemeProvider.Theme.Colors.DarkBorder))
            {
                var modRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
                g.DrawRectangle(p, modRect);
            }
        }

        #endregion
    }
}
