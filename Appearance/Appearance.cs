using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HueController.Appearance
{
    class Colors
    {
        public static Color PrimaryBackgroundDark { get { return Color.FromArgb(33, 37, 41); } }
        public static Color SecondaryDark { get { return Color.FromArgb(52, 58, 64); } }
        public static Color ForeColorDark { get { return Color.FromArgb(248, 249, 250); } }
    }

    class Borders
    {
        public static int BorderSize { get { return 0; } }
        public static int BorderRadius { get { return 40; } }
    }
}
