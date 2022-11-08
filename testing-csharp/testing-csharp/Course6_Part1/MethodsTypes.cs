using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6_Part1
{
    public class MethodsTypes
    {
        // Without parameters and without return type
        public void NoReturnNoParams()
        {
            Console.WriteLine("No return, no parameters.");
        }

        // With parameters and without return type
        public void NoReturnWithParams(int Resolution)
        {
            Console.WriteLine("No return, with parameter Resolution = " + Resolution);
        }

        // Without paratemers and with return type
        public bool WithReturnNoParams()
        {
            Console.WriteLine("With return type, without parameters");
            return true;
        }

        // With parameters and with return type
        public bool WithReturnWithParams(int Resolution)
        {
            Console.WriteLine("With return type, with parameter Resolution = " + Resolution);
            return true;
        }

        // With object parameter
        public void WithObjectParams(Object obj)
        {
            Console.WriteLine("With object parameters.");
        }
    }
}
