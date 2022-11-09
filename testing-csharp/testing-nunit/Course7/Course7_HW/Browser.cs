using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_nunit.Course7.Course7_HW
{
    public class Browser
    {
        // Class variable
        public int WindowWidth = 1024;

        // Method to start the browser
        public bool StartBrowser()
        {
            Console.WriteLine("Browser started.");
            return true;
        }

        // Method to get the browser title
        public string GetPageTitle()
        {
            return "Browser is open.";
        }

        // Method to get the browser's width
        public int GetBrowserWidth()
        {
            return WindowWidth;
        }
    }
}
