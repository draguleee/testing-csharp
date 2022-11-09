using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course6.Course6_HW.Exercise2
{
    public class HomePage
    {
        // Define the XPaths
        public string image = "//*[@id=\"header\"]/a/img";
        public string homeLink = "//*[@id=\"navHeader\"]/a[1]";
        public string htmlText = "//body/h1";
        public string body = "//body/p";
        public string email = "//body/div/form/input[@id=\"email\"]";
        public string password = "//body/div/form/input[@id=\"password\"]";
        public string loginButton = "//*[@id=\"Login\"]";
        public string homeFooter = "//footer/ul/li[1]/a";

        // Method to display the XPaths
        public void PrintXPaths()
        {
            Console.WriteLine("Image (header): " + image);
            Console.WriteLine("Home link (header): " + homeLink);
            Console.WriteLine("HTML (h1): " + htmlText);
            Console.WriteLine("Text from page (body): " + body);
            Console.WriteLine("E-mail (input): " + email);
            Console.WriteLine("Password (input): " + password);
            Console.WriteLine("Login button: " + loginButton);
            Console.WriteLine("Home (footer): " + homeFooter);
        }
    }
}