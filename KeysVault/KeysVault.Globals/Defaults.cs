using KeysVault.Entities;
using System.Drawing;

namespace KeysVault.Globals
{
    public static class Defaults
    {
        public static string DateTimeFormat = "F";
        public static bool ShowEmailColumn = true;
        public static bool ShowUsernameColumn = true;
        public static bool ShowPasswordColumn = true;
        public static string Master = "KeysVault";

        public static Settings Settings = new Settings()
        {
            DateTimeFormat = "F",
            ShowEmailColumn = true,
            ShowUsernameColumn = true,
            ShowPasswordColumn = true,
            Master = "KeysVault"
        };

        public static Color DefaultColor = Color.FromArgb(67, 140, 235);
        public static Color ErrorColor = Color.FromArgb(244, 67, 54);
        public static Color WarningColor = Color.FromArgb(245, 124, 0);

        public static string InitVector = "@1B2c3D4e5F6g7H8";
        public static int KeySize = 256;
    }
}
