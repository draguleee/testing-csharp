using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course4.Course4_HW
{
    public class Skype : IComponent, INetwork
    {
        // Method to show the details of Skype
        public void About()
        {
            Console.WriteLine("This is Skype application.");
        }

        // Method to ping Skype
        public void Ping()
        {
            Console.WriteLine("Skype ping... Done.");
        }
    }
}
