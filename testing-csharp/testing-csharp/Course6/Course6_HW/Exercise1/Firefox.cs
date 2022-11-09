using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6.Course6_HW.Exercise1
{
    public class Firefox
    {
        // Class variable
        public int WindowWidth;

        // Default constructor
        public Firefox()
        {
            Console.WriteLine("This is the default constructor. WindowWidth = " + this.WindowWidth);
        }

        // Constructor with int parameter
        public Firefox(int val)
        {
            WindowWidth = val;
            Console.WriteLine("This is a constructor with int WindowWidth = " + val);
        }

        // Constructor with double parameter
        public Firefox(double val)
        {
            WindowWidth = (int)val;
            Console.WriteLine("This is a constructor with double WindowWidth = " + val);
        }

        // Method to get the window width
        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
