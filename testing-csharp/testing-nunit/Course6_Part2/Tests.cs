using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_nunit.Course6_Part2
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FirstNunitTest()
        {
            // Expects true, receives true - passes
            Assert.True(true);      
        }

        [Test]
        public void SecondNunitTest()
        {
            // Expects false, receives false - passes
            Assert.False(false);    
        }

        [Test]
        public void ThirdNunitTest()
        {
            // Expects true, receives false - fails
            Assert.True(false);     
        }

        [Test]
        public void FourthNunitTest()
        {
            // Expects false, receives true - fails
            Assert.False(true);
        }
    }
}
