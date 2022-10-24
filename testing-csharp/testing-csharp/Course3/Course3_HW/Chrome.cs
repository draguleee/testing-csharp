using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace testing_csharp.Course3.Course3_HW
{
    class Chrome : Browser
    {
        // Method to change int window width - overriden
        public override void ChangeWindowWidth(int value)
        {
            this.WindowWidth_int = value;
            Console.WriteLine("Width (int) changed to " + value + " for Chrome.");
        }

        // Method to change string window width
        public void ChangeWindowWidth(string value)
        {
            this.WindowWidth_string = value;
            Console.WriteLine("Width (string) changed to " + value + " for Chrome.");
        }

        // Method to show details about the browser - overriden
        public override void About()
        {
            Console.WriteLine("This is Chrome browser.");
        }
    }
}
