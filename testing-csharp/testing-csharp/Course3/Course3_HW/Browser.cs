using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course3.Course3_HW
{
    class Browser
    {
        // Variables
        public int WindowWidth_int;
        public string WindowWidth_string;

        // Method to change window width - to be overriden
        public virtual void ChangeWindowWidth(int value) { }

        // Method to show details about the browser - to be overriden
        public virtual void About() { }

    }
}
