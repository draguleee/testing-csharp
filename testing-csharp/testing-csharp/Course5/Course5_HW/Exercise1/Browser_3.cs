using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course5.Course5_HW.Exercise1
{
    public class Browser_3
    {
        // Method to send text to element
        private void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                BrowserHelper.PathImage = "Test";
            }
        }

        // Method to find element
        public void FindElement()
        {
            throw new Exception("The element was not found!");
        }
    }
}
