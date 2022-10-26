using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course4.Course4_HW
{
    public class Firefox : Browser, IComponent, INetwork
    {
        // Method to display window width
        public void DisplayWindowWidth()
        {
            Console.WriteLine("Window width: " + WindowWidth);
        }

        // Method to change window width - override
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Changed window width for Firefox.");
        }

        // Method to start the browser - override
        public override void StartBrowser()
        {
            Console.WriteLine("Firefox browser has been started.");
        }

        // Method to stop the browser - override
        public override void StopBrowser()
        {
            Console.WriteLine("Firefox browser has been stopped.");
        }

        // Method to show the details of Firefox browser
        public void About()
        {
            Console.WriteLine("This is Firefox browser.");
        }

        // Method to ping the Firefox browser
        public void Ping()
        {
            Console.WriteLine("Firefox browser ping... Done.");
        }

    }
}
