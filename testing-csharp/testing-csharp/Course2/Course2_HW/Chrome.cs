using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Chrome
    {
        // Class variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        // Default constructor
        public Chrome()
        {
            Console.WriteLine("Default constructor for Chrome class.");
        }

        // Constructor with int parameter
        public Chrome(int WindowWidth_int)
        {
            Console.WriteLine("Constructor for Chrome with int parameter.");
            this.WindowWidth_int = WindowWidth_int;
        }

        // Constructor with string parameter
        public Chrome(string WindowWidth_string)
        {
            Console.WriteLine("Constructor for Chrome with string parameter.");
            this.WindowWidth_string = WindowWidth_string;
        }

        // Constructor with double parameter
        public Chrome(double WindowWidth_double)
        {
            Console.WriteLine("Constructor for Chrome with double parameter.");
            this.WindowWidth_double = WindowWidth_double;
        }

        // Method for printing the int resolution
        public void PrintWindowWidth_int()
        {
            if(WindowWidth_int > 1920)
            {
                Console.WriteLine("Window width for Chrome: " + WindowWidth_int);
            }
            else
            {
                Console.WriteLine("Window width is less than 1920.");
            }
        }

        // Getter for int parameter
        public int GetWindowWidth_int()
        {
            return this.WindowWidth_int;
        }

        // Getter for string parameter
        public string GetWindowWidth_string()
        {
            return this.WindowWidth_string;
        }

        // Getter for double parameter
        public double GetWindowWidth_double()
        {
            return this.WindowWidth_double;
        }

        // Setter for the int parameter
        public void SetWindowWidth_int(int WindowWidth_int)
        {
            this.WindowWidth_int = WindowWidth_int;
        }

        // Setter for the string parameter
        public void SetWindowWidth_string(string WindowWidth_string)
        {
            this.WindowWidth_string = WindowWidth_string;
        }

        // Setter for the double parameter
        public void SetWindowWidth_double(double WindowWidth_double)
        {
            this.WindowWidth_double = WindowWidth_double;
        }
    }
}
