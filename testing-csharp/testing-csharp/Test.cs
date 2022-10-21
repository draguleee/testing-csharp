using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
// using testing_csharp.Course1;
using testing_csharp.Course2;
using A;
using B;
using C;
using D;
using System.Runtime.InteropServices;

namespace testing_csharp
{
    class Test
    {
        static void Main(string[] args)
        {

            /* -----------------COURSE 1-----------------

            // First Program
            FirstProgram firstProgram = new FirstProgram();
            firstProgram.HelloWorld();

            // Create a Browser object 
            Browser ie = new Browser();
            Browser chrome = new Browser(1024);
            Browser firefox = new Browser(2048, 1090);
            Console.WriteLine();

            // Display Internet Explorer's width and height
            Console.WriteLine("DISPLAYING WIDTH AND HEIGHT FOR INTERNET EXPLORER");
            Console.WriteLine("Internet Explorer's window width is: " + ie.ShowWindowWidth());
            Console.WriteLine("Internet Explorer's window height is: " + ie.ShowWindowHeight());
            ie.ShowWindowWidthHeight();
            ie.ChangeWindowWidth(1920);
            ie.ChangeWindowHeight(1080);
            Console.WriteLine("Internet Explorer's new window width is: " + ie.ShowWindowWidth());
            Console.WriteLine("Internet Explorer's new window height is: " + ie.ShowWindowHeight());
            ie.ShowWindowWidthHeight();
            Console.WriteLine();

            // Display Chrome's width and height
            Console.WriteLine("DISPLAYING WIDTH AND HEIGHT FOR CHROME");
            Console.WriteLine("Chrome's window width is: " + chrome.ShowWindowWidth());
            Console.WriteLine("Chrome's window height is: " + chrome.ShowWindowHeight());
            chrome.ShowWindowWidthHeight();
            chrome.ChangeWindowWidth(1024);
            chrome.ChangeWindowHeight(920);
            Console.WriteLine("Chrome's new window width is: " + chrome.ShowWindowWidth());
            Console.WriteLine("Chrome's new window height is: " + chrome.ShowWindowHeight());
            chrome.ShowWindowWidthHeight();
            Console.WriteLine();

            // Display Firefox's width and height
            Console.WriteLine("DISPLAYING WIDTH AND HEIGHT FOR FIREFOX");
            Console.WriteLine("Firefox's window width is: " + firefox.ShowWindowWidth());
            Console.WriteLine("Firefox's window height is: " + firefox.ShowWindowHeight());
            firefox.ShowWindowWidthHeight();
            firefox.ChangeWindowWidth(1024);
            firefox.ChangeWindowHeight(820);
            Console.WriteLine("Firefox's new window width is: " + firefox.ShowWindowWidth());
            Console.WriteLine("Firefox's new window height is: " + firefox.ShowWindowHeight());
            firefox.ShowWindowWidthHeight();
            Console.WriteLine();

            */


            /* -----------------COURSE 2-----------------
            
            // Data Types
            Console.WriteLine("DATA TYPES");
            DataTypes ds = new DataTypes();
            ds.display();
            Console.WriteLine();

            // Conversions
            Console.WriteLine("PRE & POST INCREMENT");
            ds.PreIncrement(10);        // 10
            ds.PostIncrement(10);       // 11
            Console.WriteLine();

            // Operators
            Console.WriteLine("OPERATORS");
            int x = 5;
            int y = 3;
            ds.PlusEq(x, y);
            ds.MinusEq(x,y);
            ds.MulEq(x,y);
            ds.DivEq(x,y);
            Console.WriteLine();

            // If statement
            Console.WriteLine("IF STATEMENT");
            ds.IfStatement(8,2);
            Console.WriteLine();

            // If-Else statement
            Console.WriteLine("IF-ELSE STATEMENT");
            ds.IfElseStatement(4, 2);
            ds.IfElseStatement(5, -3);
            ds.IfElseStatement(7, 7);
            Console.WriteLine();

            // Switch-Case
            Console.WriteLine("SWITCH-CASE");
            ds.SwitchCase(1);
            ds.SwitchCase(2);
            ds.SwitchCase(8);
            Console.WriteLine();

            // While Loop
            Console.WriteLine("WHILE LOOP");
            ds.WhileLoop(10);
            Console.WriteLine();

            // For Loop
            Console.WriteLine("FOR LOOP");
            ds.ForLoop(10);
            Console.WriteLine();

            // Do-While Loop
            Console.WriteLine("DO-WHILE LOOP");
            ds.DoWhileLoop(10);
            Console.WriteLine();

            */


            /* -----------------COURSE 2 HOMEWORK----------------- */

            // Create objects for Browser class
            Console.WriteLine("BROWSER CLASS");
            Browser browser1 = new Browser();
            Browser browser2 = new Browser(1920);       // int
            Console.WriteLine("Resolution (int) for Browser: " + browser2.GetWindowWidth_int());
            Browser browser3 = new Browser("1080");     // string
            Console.WriteLine("Resolution (string) for Browser: " + browser3.GetWindowWidth_string());
            Browser browser4 = new Browser(144.0);     // double
            Console.WriteLine("Resolution (double) for Browser: " + browser4.GetWindowWidth_double());
            Console.WriteLine();

            // Create objects for Firefox class
            Console.WriteLine("FIREFOX CLASS");
            Firefox firefox1 = new Firefox();
            Firefox firefox2 = new Firefox(1080);       // int
            Console.WriteLine("Resolution (int) for Firefox: " + firefox2.GetWindowWidth_int());
            Firefox firefox3 = new Firefox("2048");     // string
            Console.WriteLine("Resolution (string) for Firefox: " + firefox3.GetWindowWidth_string());
            Firefox firefox4 = new Firefox(920.0);     // double
            Console.WriteLine("Resolution (double) for Firefox: " + firefox4.GetWindowWidth_double());
            Console.WriteLine("Converted resolution (int -> string): " + Convert.ToString(firefox2.GetWindowWidth_int()));
            Console.WriteLine("Converted resolution (string -> double): " + Convert.ToDouble(firefox3.GetWindowWidth_string()));
            Console.WriteLine("Converted resolution (double -> int): " + Convert.ToInt32(firefox4.GetWindowWidth_double()));
            Console.WriteLine();

            // Create objects for Chrome class
            Console.WriteLine("CHROME CLASS");
            Chrome chrome1 = new Chrome();
            Chrome chrome2 = new Chrome(2048);
            Chrome chrome3 = new Chrome(1080);
            chrome2.PrintWindowWidth_int();
            chrome3.PrintWindowWidth_int();
            Console.WriteLine();

            // Create objects for Internet Explorer class
            Console.WriteLine("INTERNET EXPLORER");
            InternetExplorer internetExplorer1 = new InternetExplorer();
            InternetExplorer internetExplorer2 = new InternetExplorer(2440);
            InternetExplorer internetExplorer3 = new InternetExplorer(820);
            internetExplorer2.PrintWindowWidth_int();
            internetExplorer3.PrintWindowWidth_int();
            /* COURSE 3 */


            Console.ReadLine();
        }
    }
}