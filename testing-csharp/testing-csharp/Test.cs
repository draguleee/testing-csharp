using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// using testing_csharp.Course1;
// using testing_csharp.Course1.Course1_HW;
// using testing_csharp.Course2;
// using testing_csharp.Course2.Course2_HW;
// using testing_csharp.Course3;
// using testing_csharp.Course3.Course3_HW;
// using testing_csharp.Course4.AbstractClasses;
// using testing_csharp.Course4.Interfaces;
// using testing_csharp.Course4.Encapsulation;
// using testing_csharp.Course4.Course4_HW;
// using testing_csharp.Course5.Exceptions;
// using testing_csharp.Course5.StaticMembers;
// using testing_csharp.Course5.Course5_HW.Exercise1;
// using testing_csharp.Course5.Course5_HW.Exercise2;
// using testing_csharp.Course6;
// using testing_csharp.Course6.Course6_HW.Exercise1;
// using testing_csharp.Course6.Course6_HW.Exercise2;
// using testing_csharp.Course6.Course6_HW.Exercise3;
// using A;
// using B;
// using C;
// using D;

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

            // Create Browser objects
            Browser browser1 = new Browser();
            Browser browser2 = new Browser(1600);

            // Call a method
            browser1.ChangeWindowWidth(1600);
            browser2.ChangeWindowWidth(1920);

            */


            /* -----------------COURSE 1 HOMEWORK-----------------

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


            /* -----------------COURSE 2 HOMEWORK----------------- 

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
            Console.WriteLine();

            */


            /* -----------------COURSE 3----------------- 

            // Create objects 
            Firefox firefox = new Firefox();
            InternetExplorer ie = new InternetExplorer();

            // Change window width for Firefox object
            Console.WriteLine("FIREFOX");
            firefox.ChangeWindowWidth(1080);
            firefox.ChangeWindowWidth("2048");
            firefox.ChangeWindowWidth(1920.0);
            Console.WriteLine();

            // Change window width for InternetExplorer object
            Console.WriteLine("INTERNET EXPLORER");
            ie.ChangeWindowWidth(1440);
            ie.ChangeWindowWidth("720");
            ie.ChangeWindowWidth(2440.0);
            Console.WriteLine();

            */


            /* -----------------COURSE 3 HOMEWORK----------------- 

            // Create objects for Firefox, Chrome, InternetExplorer and Edge
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer ie = new InternetExplorer();
            Edge edge = new Edge();

            // Call available methods for Firefox class
            Console.WriteLine("FIREFOX");
            firefox.About();
            firefox.SetProfileName("Andre");
            firefox.ChangeWindowWidth(1080);
            Console.WriteLine();

            // Call available methods for Chrome class
            Console.WriteLine("CHROME");
            chrome.About();
            chrome.ChangeWindowWidth(1920);
            chrome.ChangeWindowWidth("1440");
            Console.WriteLine();

            // Call available methods for InternetExplorer class
            Console.WriteLine("INTERNET EXPLORER");
            ie.About();
            ie.ChangeWindowWidth(920);
            Console.WriteLine();

            // Call available methods for Edge class
            Console.WriteLine("EDGE");
            edge.About();
            edge.SetVersion(120);
            edge.NewFeatureFunction();
            edge.ChangeWindowWidth(2040);
            Console.WriteLine();

            */


            /* -----------------COURSE 4----------------- 

            // Create Firefox and Internet Explorer objects
            Console.WriteLine("ABSTRACT CLASSES");
            testing_csharp.Course4.AbstractClasses.Firefox firefox1 = new testing_csharp.Course4.AbstractClasses.Firefox();
            testing_csharp.Course4.AbstractClasses.InternetExplorer ie = new testing_csharp.Course4.AbstractClasses.InternetExplorer();

            // Test the About() method
            Console.WriteLine("TEST THE About() METHOD");
            firefox1.About();
            ie.About();
            Console.WriteLine();

            // Create Firefox and Skype objects 
            Console.WriteLine("INTERFACES");
            testing_csharp.Course4.Interfaces.Firefox firefox2 = new testing_csharp.Course4.Interfaces.Firefox();
            testing_csharp.Course4.Interfaces.Skype skype = new testing_csharp.Course4.Interfaces.Skype();

            // Test the About() method
            Console.WriteLine("TEST THE About() METHOD");
            firefox2.About();
            skype.About();
            Console.WriteLine();

            // Encapsulation
            Console.WriteLine("ENCAPSULATION");
            testing_csharp.Course4.Encapsulation.Firefox firefox3 = new testing_csharp.Course4.Encapsulation.Firefox();
            firefox3.WindowWidth = -1;
            firefox3.StartBrowser();

            */


            /* -----------------COURSE 4 HOMEWORK----------------- 

            // Create Firefox and Skype objects
            Firefox firefox = new Firefox();
            Skype skype = new Skype();

            // Test the methods of Firefox class
            Console.WriteLine("FIREFOX");
            firefox.StartBrowser();
            firefox.Ping();
            firefox.About();
            firefox.DisplayWindowWidth();
            firefox.ChangeWindowWidth(2048);
            firefox.StopBrowser();
            Console.WriteLine();

            // Test the methods of Skype class
            Console.WriteLine("SKYPE");
            skype.Ping();
            skype.About();
            Console.WriteLine();

            */


            /* -----------------COURSE 5----------------- 

            // Exception handling
            Console.WriteLine("EXCEPTION HANDLING");
            testing_csharp.Course5.Exceptions.Math operation = new testing_csharp.Course5.Exceptions.Math();
            operation.Division(2, 0);
            Consiole.WriteLine();

            // Static members
            Console.WriteLine("STATIC MEMBERS");
            StaticClass.Number = 10;
            StaticClass.DisplayNumber();
            Console.WriteLine();

            */


            /* -----------------COURSE 5 HOMEWORK----------------- 

            // Create Browser objects and test the accesibility level
            Console.WriteLine("EXCEPTIONS & STATIC MEMBERS");
            Browser_1 browser1 = new Browser_1();       // public
            Browser_2 browser2 = new Browser_2();       // internal
            Browser_3 browser3 = new Browser_3();       // private
            Browser_4 browser4 = new Browser_4();       // internal protected
            Browser_5 browser5 = new Browser_5();       // protected
            Browser_6 browser6 = new Browser_6();       // default private 
            browser1.SendTextToElement();   
            browser2.SendTextToElement();
            // browser3.SendTextToElement();
            browser4.SendTextToElement();
            // browser5.SendTextToElement();
            // browser6.SendTextToElement();   
            Console.WriteLine();

            // Create Chrome, Firefox and Edge objects and test the TestAccess() method
            Console.WriteLine("ACCESS MODIFIERS");
            testing_csharp.Course5.Course5_HW.Exercise2.Chrome chrome = new testing_csharp.Course5.Course5_HW.Exercise2.Chrome();
            testing_csharp.Course5.Course5_HW.Exercise2.Firefox firefox = new testing_csharp.Course5.Course5_HW.Exercise2.Firefox();
            testing_csharp.Course5.Course5_HW.Exercise2.Edge edge = new testing_csharp.Course5.Course5_HW.Exercise2.Edge();
            Console.WriteLine("Chrome: ");
            chrome.TestAccess();
            Console.WriteLine();
            Console.WriteLine("Firefox: ");
            firefox.TestAccess();
            Console.WriteLine();
            Console.WriteLine("Edge: ");
            edge.TestAccess();
            Console.WriteLine();

            */


            /* -----------------COURSE 6-----------------

            // Show default values
            Console.WriteLine("DEFAULT VALUES");
            DefaultValues defaultValues = new DefaultValues();
            defaultValues.ShowDefaultValues();
            Console.WriteLine();

            // Methods types
            Console.WriteLine("METHODS TYPES");
            MethodsTypes ms = new MethodsTypes();
            ms.NoReturnNoParams();
            ms.NoReturnWithParams(1080);
            ms.WithReturnNoParams();
            ms.WithReturnWithParams(1920);
            ms.WithObjectParams(defaultValues);
            Console.WriteLine();

            // Arrays, For and Foreach
            Console.WriteLine("ARRAYS, FOR AND FOREACH");
            Arrays arrays = new Arrays();
            arrays.ArrayMethod();
            arrays.ArrayMethodFor();
            arrays.ArrayMethodForeach();
            Console.WriteLine("\n");

            // Lists
            Console.WriteLine("LISTS");
            Lists lists = new Lists();
            lists.ListMethod();
            lists.ListMethodForeach();
            Console.WriteLine("\n");

            // XPaths
            Console.WriteLine("XPATHS");
            XPaths paths = new XPaths();
            paths.PrintXPaths();
            Console.WriteLine();

            */


            /* -----------------COURSE 6 HOMEWORK-----------------

            // Exercise 1
            Console.WriteLine("EXERCISE 1");
            testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise1.Firefox firefox11 = new testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise1.Firefox();
            testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise1.Firefox firefox12 = new testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise1.Firefox();
            testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise1.Firefox firefox13 = new testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise1.Firefox();
            int WindowWidth11 = firefox11.GetWindowWidth();
            int WindowWidth12 = firefox12.GetWindowWidth();
            int WindowWidth13 = firefox13.GetWindowWidth();
            Console.WriteLine();

            // Exercise 2
            Console.WriteLine("EXERCISE 2");
            HomePage homepage = new HomePage();
            homepage.PrintXPaths();
            Console.WriteLine();

            // Exercise 3
            Console.WriteLine("EXERCISE 3");
            testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise3.Firefox firefox31 = new testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise3.Firefox();
            testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise3.Firefox firefox32 = new testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise3.Firefox(2040);
            testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise3.Firefox firefox33 = new testing_csharp.Course6_Part1.Course6_Part1_HW.Exercise3.Firefox("1440");
            int WindowWidth31 = firefox31.GetWindowWidth();
            int WindowWidth32 = firefox32.GetWindowWidth();
            int WindowWidth33 = firefox33.GetWindowWidth();
            TestsRunner testsRunner = new TestsRunner();
            testsRunner.Run(firefox31);
            testsRunner.Run(firefox32);
            testsRunner.Run(firefox33);
            Console.WriteLine();

            */

            Console.ReadLine();
        }
    }
}
