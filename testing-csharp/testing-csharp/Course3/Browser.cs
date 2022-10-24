using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course3
{
    class Browser
    {
        // Variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        // Method to change int window width - to be overriden
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            Console.WriteLine(WindowWidth_int);
        }

        // Method to change string window width - to be overriden
        public virtual void ChangeWindowWidth(string newWindowWidth)
        {
            Console.WriteLine(WindowWidth_string);
        }

        // Method to change double window width - to be overriden
        public virtual void ChangeWindowWidth(double newWindowWidth)
        {
            Console.WriteLine(WindowWidth_double);
        }
    }
}
