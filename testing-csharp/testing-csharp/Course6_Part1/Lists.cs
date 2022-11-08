using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6_Part1
{
    public class Lists
    {
        // Class variable
        List<string> browsers = new List<string> { "chrome", "firefox", "edge", "opera" };

        // Method for displaying list elements (simple)
        public void ListMethod()
        {
            Console.WriteLine("List method (simple): " + browsers[0] + ", " + browsers[1] + ", " + browsers[2] + ", " + browsers[3]);
        }

        // Method for displaying list elements (foreach)
        public void ListMethodForeach()
        {
            Console.Write("List method (foreach): ");
            foreach (var browser in browsers)
            {
                Console.Write(browser + " ");
            }
        }
    }
}
