using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course5.AccessModifiers
{
    class AccessModifiersChildClass : AccessModifiers
    {
        public void testAccess()
        {
            TestPublic();
            TestInternal();
            TestProtected();
            TestInternalProtected();
            // TestPrivate();
            // TestDefaultPrivate();
        }
    }
}
