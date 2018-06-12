using System;

namespace szamokNegyzeteVegjelig
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = Console.ReadLine();
                try
                {
                    var number = Convert.ToInt32(input);
                    Console.WriteLine(number * number);
                } catch(Exception e) {
                    
                }
            } while (input != @"c"); 
        }
    }
}
