using DarkUI.Config;
using System.Windows.Forms;

namespace DarkUI.Controls
{
    public class DarkTextBox : TextBox
    {
        #region Constructor Region

        public DarkTextBox()
        {
            BackColor = ThemeProvider.Theme.Colors.LightBackground;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
            Padding = new Padding(2, 2, 2, 2);
            BorderStyle = BorderStyle.FixedSingle;
        }

        //protected override void OnInvalidated(InvalidateEventArgs e)
        //{
        //    BackColor = ThemeProvider.Theme.Colors.LightBackground;
        //    ForeColor = ThemeProvider.Theme.Colors.LightText;
        //    Padding = new Padding(2, 2, 2, 2);
        //    BorderStyle = BorderStyle.FixedSingle;

        //    base.OnInvalidated(e);
        //}
        #endregion
    }
}
