using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course3.Course3_HW
{
    class Firefox : Browser
    {
        // Variables
        public string profileName;

        // Method to set profile name
        public void SetProfileName(string newProfileName)
        {
            this.profileName = newProfileName;
            Console.WriteLine("Profile " + newProfileName + " set for Firefox.");
        }

        // Method to get profile name
        public string GetProfileName()
        {
            return this.profileName;
        }

        // Method to change int window width - overriden
        public override void ChangeWindowWidth(int value)
        {
            this.WindowWidth_int = value;
            Console.WriteLine("Width (int) changed to " + value + " for Firefox.");
        }

        // Method to show details about the browser - overriden
        public override void About()
        {
            Console.WriteLine("This is Firefox browser.");
        }
    }
}
