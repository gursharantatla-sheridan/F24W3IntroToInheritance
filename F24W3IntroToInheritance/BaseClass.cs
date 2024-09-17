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

        public BaseClass(string message)
        {
            Console.WriteLine("Base class constructor with message: " + message);
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived class constructor called");
            myVar = 1;
        }

        public DerivedClass(string msg) : base(msg)
        {
            Console.WriteLine("Derived class constructor called");
            myVar = 1;
        }
    }
}
