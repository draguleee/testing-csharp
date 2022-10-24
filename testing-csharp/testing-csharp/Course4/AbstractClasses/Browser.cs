using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course4.AbstractClasses
{
    public abstract class Browser
    {
        // Class variables
        public int WindowWidth;

        // Method to change window width
        public void ChangeWindowWidth(int newWindowWidth)
        {
            this.WindowWidth = newWindowWidth;
        }

        // Abstract method to display the details about the browser
        public abstract void About();
    }
}
