using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course3
{
    class Debug
    {
        public static void DebugFunction()
        {
            char[] letters = { 'r', 'o', 's', 'i', 'e', ' ', 'a', 'n', 'd', 'r', 'e'};
            string name = "";
            int[] a = new int[letters.Length];
            for(int i=0; i<letters.Length; i++)
            {
                name += letters[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }
            Console.ReadKey();
        }

        public static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + msg);
        }
    }
}
