using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course4.Interfaces
{
    class Firefox : IComponent
    {
        // Implement the About() method
        public void About()
        {
            Console.WriteLine("About Firefox.");
        }
    }
}
