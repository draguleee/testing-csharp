using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6_Part1
{
    public class Arrays
    {
        // Class variable
        string[] browsers = { "chrome", "firefox", "edge", "opera" };

        // Method for displaying array elements (simple)
        public void ArrayMethod()
        {
            Console.WriteLine("Array method (simple): " + browsers[0] + ", " + browsers[1] + ", " + browsers[2] + ", " + browsers[3]);
        }

        // Method for displaying array elements (for)
        public void ArrayMethodFor()
        {
            Console.Write("Array method (for): ");
            for(int i=0; i<browsers.Length; i++)
            {
                Console.Write(browsers[i] + " "); 
            }
        }

        // Method for displaying array elements (foreach)
        public void ArrayMethodForeach()
        {
            Console.Write("\nArray method (foreach): ");
            foreach (var browser in browsers)
            {
                Console.Write(browser + " ");
            }
        }
    }
}
