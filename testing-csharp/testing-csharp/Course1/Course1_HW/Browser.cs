using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course1
{
    class Browser
    {

        // Variable
        public int windowWidth;
        public int windowHeight;

        // Default constructor
        public Browser()
        {
            Console.WriteLine("Default Constructor for Browser class.");
            windowWidth = 1024;
            windowHeight = 920;
        }

        // Constructor with parameters
        public Browser(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
        }

        // Constructor with two parameters
        public Browser(int newWindowWidth, int newWindowHeight)
        {
            windowWidth = newWindowWidth;
            windowHeight = newWindowHeight;
        }

        // Method to change window width
        public void ChangeWindowWidth(int newWindowWidth)
        {
            windowWidth = newWindowWidth;
        }

        // Method to change window height
        public void ChangeWindowHeight(int newWindowHeight)
        {
            windowHeight = newWindowHeight;
        }

        // Method to change window width and height
        public void ChangeWindowWidthHeight(int newWindowWidth, int newWindowHeight)
        {
            windowWidth = newWindowWidth;
            windowHeight = newWindowHeight;
        }

        // Method to show window width
        public int ShowWindowWidth()
        {
            return windowWidth;
        }

        // Method to show window height
        public int ShowWindowHeight()
        {
            return windowHeight;
        }

        // Method to show window width and height
        public void ShowWindowWidthHeight()
        {
            Console.WriteLine("Resolution: " + windowWidth + " X " + windowHeight);
        }
    }
}