using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course3
{
    class Firefox : Browser
    {
        // Method to change int window width - overriden
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            this.WindowWidth_int = newWindowWidth;
            Console.WriteLine("Change int window width for Firefox to " + newWindowWidth);
        }

        // Method to change string window width - overriden
        public override void ChangeWindowWidth(string newWindowWidth)
        {
            this.WindowWidth_string = newWindowWidth;
            Console.WriteLine("Change string window width for Firefox to " + newWindowWidth);
        }

        // Method to change double window width - overriden
        public override void ChangeWindowWidth(double newWindowWidth)
        {
            this.WindowWidth_double = newWindowWidth;
            Console.WriteLine("Change double window width for Firefox to " + newWindowWidth);
        }
    }
}
