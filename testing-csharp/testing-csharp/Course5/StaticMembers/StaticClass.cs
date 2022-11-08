using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course5.StaticMembers
{
    static class StaticClass
    {
        // Static variable
        public static int Number = 5;

        // Static method
        public static void DisplayNumber()
        {
            Console.WriteLine("Number is: " + Number);
        }
    }
}
