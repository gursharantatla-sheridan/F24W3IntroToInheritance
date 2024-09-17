namespace F24W3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass objDerived = new DerivedClass();
            //objDerived.myPrivateVar = 1;
            //objDerived.myProtectedVar = 2;
            objDerived.myPublicVar = 3;
        }
    }
}
