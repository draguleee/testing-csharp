using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise3
{
    public class TestsRunner
    {
        // Run tests
        public void Run(Firefox firefox)
        {
            Console.WriteLine("Running Firefox with window width " + firefox.GetWindowWidth());
        }
    }
}
