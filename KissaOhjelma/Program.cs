using System;

namespace KissaOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Kissa01 = new Cat();
            Kissa01.name = "Miuku";
            Console.WriteLine("Kissa01 name: " + Kissa01.GetName());
            Kissa01.SetName("Mauku");
            Console.WriteLine("Kissa01 name: " + Kissa01.GetName());
            Console.WriteLine("Kissa01 age: " + Kissa01.GetAge());

            Cat Kissa02 = new Cat(13, "Mouru");
            Console.WriteLine("Kissa02 name: " + Kissa02.GetName());
            Console.WriteLine("Kissa02 age: " + Kissa02.GetAge());
        }
    }
}
