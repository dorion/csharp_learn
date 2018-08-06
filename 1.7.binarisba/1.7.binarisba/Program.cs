using System;

namespace _1._7.binarisba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szám ami binárisba lesz kiírva:");
            var number = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2));
        }
    }
}
