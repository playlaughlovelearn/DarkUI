using System;
namespace DarkUI.Config
{
    public class ThemeProvider
    {
        private static ITheme theme = new DarkTheme();
        public static ITheme Theme
        {
            get => theme;
            set
            {
                theme = value;

                if (ThemeProvider.ThemeChanged != null)
                    ThemeProvider.ThemeChanged();
            }
        }

        public static event Action ThemeChanged = null;
    }
}
