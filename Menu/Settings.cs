using StupidTemplate.Classes;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient{isRainbow = true};
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(Color.brown) }, // Disabled
            new ExtGradient{{colors = GetSolidGradient(Color.grey) } // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.grey, // Disabled
            Color.black // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Lucida Console.ttf") as Font);

        public static bool fpsCounter = true;
        public static bool disconnectButton = false;
        public static bool rightHanded = true;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1.1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
