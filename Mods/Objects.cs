using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods
{
    internal class Objects
    {
        bool isVolcano = false;
        bool isValentine = false;
      
        private string[] valentines = {"NTC"} 
        private string[] volcanos = {"NTC"} 
      
        public static void Volcano()
        {
            foreach (string volcanostuff in volcanos)
            {
                GameObject.Find(volcanostuff).active = true;
            }
            bool isVolcano = true;
        }
      
        public static void Valentine()
        {
            foreach (string valentinestuff in valentines)
            {
                GameObject.Find(valentinestuff).active = true;
            }
            bool isValentine = true;
        }
      
        public static void DisableEnabled()
        {
            if (isValentine)
            {
                foreach (string valentinestuff in valentines)
                {
                GameObject.Find(valentinestuff).active = false;
                }
                bool isValentine = false;
            }
            else if (!isValentine)
            {
                // NTC
            }
            if (isVolcano)
            {
                foreach (string volcanostuff in volcanos)
                {
                GameObject.Find(volcanostuff).active = false;
                }
                bool isVolcano = false;
            }
            else if (!isVolcano)
            {
                // NTC
            }
        }
        public static void IllAddMore()
        {
            // maybe
        }
        public static void ReturnHome()
        {
            buttonsType = 0;
        }
    }
}
