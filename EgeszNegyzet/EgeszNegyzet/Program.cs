using System;

namespace EgeszNegyzet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot:");
            var number = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(number * number);
        }
    }
}
