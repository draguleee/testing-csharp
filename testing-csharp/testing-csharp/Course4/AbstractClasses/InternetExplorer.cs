using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course4.AbstractClasses
{
    class InternetExplorer : Browser
    {
        // Implement the abstract method About()
        public override void About()
        {
            Console.WriteLine("This is Internet Explorer browser.");
        }
    }
}
