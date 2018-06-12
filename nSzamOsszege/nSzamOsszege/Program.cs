using System;

namespace nSzamOsszege
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1000;
            var sum = 0;
            for (var i = 0; i < n; i++) {
                sum += i;
            }
            Console.WriteLine(sum);   
        }
    }
}
