using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W3IntroToInheritance
{
    public class BaseClass
    {
        protected int myVar;

        public BaseClass()
        {
            Console.WriteLine("Base class constructor called");
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived class constructor called");
            myVar = 1;
        }
    }
}
