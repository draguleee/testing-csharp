using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course5.AccessModifiers
{
    public class AccessModifiers
    {
        public void TestAccess()
        {
            TestPublic();
            TestInternal();
            TestProtected();
            TestInternalProtected();
            TestPrivate();
            TestDefaultPrivate();
        }

        // Public method
        public void TestPublic() { }

        // Internal method
        internal void TestInternal() { }

        // Protected method
        protected void TestProtected() { }

        // Internal protected method
        internal protected void TestInternalProtected() { }

        // Private method
        private void TestPrivate() { }

        // Default method
        void TestDefaultPrivate() { }
    }
}
