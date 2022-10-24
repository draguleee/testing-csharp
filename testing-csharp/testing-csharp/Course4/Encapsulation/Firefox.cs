using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course4.Encapsulation
{
    public class Firefox
    {
        // Class variables
        private int windowWidth = 1920;

        // Getters and setters for the WindowWidth parameter
        public int WindowWidth
        {
            get { return windowWidth; }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("You cannot set this to a value less than 0!");
                } 
                else
                {
                    WindowWidth = value;
                }
            }
        }

        // Method to start the browser
        public virtual void StartBrowser()
        {
            Console.WriteLine("Starting browser with window width: " + WindowWidth);
        }
    }
}
