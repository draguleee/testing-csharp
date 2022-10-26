using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course5
{
    public class Math
    {
        // Class variables
        int result;

        // Method to execute the division between two numbers
        public void Division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}" + e);
            }
            finally
            {
                Console.WriteLine("Result {0}: " + result);
            }
        }

        // Method that throws exception
        public void ThrowExceptionMethod()
        {
            throw new Exception("Something went wrong.");
        }
    }
}
