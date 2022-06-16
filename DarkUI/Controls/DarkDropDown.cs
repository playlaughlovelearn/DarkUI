using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DarkUI.Config;

namespace DarkUI.Controls
{
    public class DarkDropDown : ComboBox
    {
        public DarkDropDown()
        {
            BackColor = ThemeProvider.Theme.Colors.LightBackground;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
        }
    }
}
