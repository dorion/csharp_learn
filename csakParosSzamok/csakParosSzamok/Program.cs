using System;

namespace szamokVisszafele
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 10; i > 0; i--)
                if ((i % 2) == 0)
                    Console.WriteLine(i);
        }
    }
}
