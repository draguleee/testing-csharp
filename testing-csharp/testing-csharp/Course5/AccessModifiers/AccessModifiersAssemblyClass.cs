using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_csharp.Course5.AccessModifiers
{
    class AccessModifiersAssemblyClass
    {
        public void testAccess()
        {
            AccessModifiers am = new AccessModifiers();
            am.TestPublic();
            am.TestInternal();
            // am.TestProtected();
            am.TestInternalProtected();
            // am.TestPrivate();
            // am.TestDefaultPrivate();
        }
    }
}
