using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course3.Course3_HW
{
    class InternetExplorer : Browser
    {
        // Method to change int window width - overriden
        public override void ChangeWindowWidth(int value)
        {
            this.WindowWidth_int = value;
            Console.WriteLine("Width (int) changed to " + value + " for Internet Explorer.");
        }

        // Method to show details about the browser - overriden
        public override void About()
        {
            Console.WriteLine("This is Internet Explorer browser.");
        }
    }
}
