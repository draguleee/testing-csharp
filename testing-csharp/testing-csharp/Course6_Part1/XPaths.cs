using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6_Part1
{
    public class XPaths
    {
        // Examples of XPaths
        public string tagname = "//div/h1";
        public string attribute = "//div/h1[@class='myDesk']";
        public string text = "//div/h1[text()='my text']";
        public string nth = "(xpath)[n]";
        public string contains = "//a[contains(text(),'Hom')]";
        public string anytag = "//*[contains(text(),'Ho')]";

        // Method to print the XPaths
        public void PrintXPaths()
        {
            Console.WriteLine("Tagname: " + tagname);
            Console.WriteLine("Attribute: " + attribute);
            Console.WriteLine("Text: " + text);
            Console.WriteLine("N'th element: " + nth);
            Console.WriteLine("Contains: " + contains);
            Console.WriteLine("Any tag: " + anytag);
        }
    }
}
