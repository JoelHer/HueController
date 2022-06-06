using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HueController
{
    
    static class Program
    {
        private static HueBridge hb = new HueBridge();
        public static string lang = "en-en";
        private static string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string dataDir = roamingDir + "\\HueController";
        private static string langDir = dataDir + "\\lang";
        private static string currentDir = Directory.GetCurrentDirectory();

        static void Main()
        {
            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }

            if (!Directory.Exists(langDir))
            {
                Directory.CreateDirectory(langDir);
            }

            if (lang == "en-en")
            {
                Console.WriteLine(currentDir);
            }

            Application.Run(new Form1());
        }
    }
}
