using System;

namespace interval3or5
{
    class Program
    {
        static void Main(string[] args)
        {
            while() {
                
            }
            Console.WriteLine("Min:");
            var min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max:");
            var max = Convert.ToInt32(Console.ReadLine());

            for (; min < max; min++)
            {
                if ((min % 3) == 0 && (min % 5) == 0)
                {
                    Console.WriteLine(min);
                }
            }
        }
    }
}