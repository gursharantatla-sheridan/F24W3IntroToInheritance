using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W3IntroToInheritance
{
    public class BaseClass
    {
        private int myPrivateVar;
        protected int myProtectedVar;
        public int myPublicVar;
    }

    public class DerivedClass : BaseClass
    {
        public void M1()
        {
            //myPrivateVar = 1;
            myProtectedVar = 2;
            myPublicVar = 3;
        }
    }
}
