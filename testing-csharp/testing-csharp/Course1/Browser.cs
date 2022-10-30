using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course1
{
    // Class
    public class Browser
    {
        // Variable
        public int WindowWidth = 1024;

        // Default constructor
        public Browser() { }

        // Constructor with parameters
        public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("New window width: " + WindowWidth);
        }

        // Method
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("New window width: " + WindowWidth);
        }
    }
}
