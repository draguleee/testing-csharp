using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course3.Course3_HW
{
    class Edge : InternetExplorer
    {
        // Vairbales
        public int version;

        // Method to set the version
        public void SetVersion(int version)
        {
            this.version = version;
            Console.WriteLine("Version set to " + version + ".");
        }

        // Method to display new feature
        public void NewFeatureFunction()
        {
            Console.WriteLine("New feature in version " + version + ".");
        }

        // Method to change the int window width - overriden
        public override void ChangeWindowWidth(int value)
        {
            this.WindowWidth_int = value;
            Console.WriteLine("Width (int) changed to " + value + " for Edge.");
        }

        // Method to show details about the browser - overriden
        public override void About()
        {
            Console.WriteLine("This is Edge browser.");
        }
    }
}
