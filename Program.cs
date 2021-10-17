using System;

namespace Deault_Constructor
{
    using System;
    namespace DefaultConstructorExample
    {
        class Geek
        {
            int num;
            string name;
            Geek()
            {
                Console.WriteLine("Constructor Called and feilds are assigned with default values");
            }
            public static void Main()
            {
                Geek geek1 = new Geek();
                Console.WriteLine(geek1.name);
                Console.WriteLine(geek1.num);
            }
        }
    }
}
