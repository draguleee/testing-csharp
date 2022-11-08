using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course5.Course5_HW.Exercise2
{
    public class Firefox
    {
        public void TestAccess()
        {
            Browser browser = new Browser();
            Console.WriteLine("Public: " + browser.PublicResolution);
            Console.WriteLine("Internal: " + browser.InternalResolution);
            // Console.WriteLine("Private: " + browser.PrivateResolution);
            // Console.WriteLine("Protected: " + browser.ProtectedResolution);
            Console.WriteLine("Protected Internal: " + browser.ProtectedInternalResolution);
            // Console.WriteLine("Default Private: " + browser.Resolution);
        }
    }
}
