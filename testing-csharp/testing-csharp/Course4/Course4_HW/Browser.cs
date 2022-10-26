using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course4.Course4_HW
{
    public abstract class Browser
    {
        // Variables
        private int windowWidth;

        // Getters and setters for windowWidth parameter
        public int WindowWidth
        {
            get { return this.windowWidth; }
            set
            {
                if(value >= 1024 && value <= 1920)
                {
                    this.windowWidth = value;
                }
                else
                {
                    Console.WriteLine("Window width must be in the [1024,1920] range.");
                }
            }
        }

        // Method to change window width
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Changed window width for Browser.");
        }

        // Abstract method to start the browser
        public abstract void StartBrowser();

        // Abstract method to stop the browser
        public abstract void StopBrowser();
    }
}
