using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6.Course6_HW.Exercise3
{
    public class Firefox
    {
        // Class variable
        public int WindowWidth;

        // Default constructor
        public Firefox() 
        {
            Console.WriteLine("Default constructor with WindowWidth = " + WindowWidth);
        }

        // Constructor with int parameters
        public Firefox(int val)
        {
            WindowWidth = val;
            Console.WriteLine("Constructor with int WindowWidth = " + val);
        }

        // Constructor with string parameters
        public Firefox(string val)
        {
            WindowWidth = Convert.ToInt32(val);
            Console.WriteLine("Constructor with string WindowWidth = " + val);
        }

        // Method to get window width
        public int GetWindowWidth()
        {
            return WindowWidth; 
        }
    }
}
