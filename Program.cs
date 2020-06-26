using System;

namespace Recursividade_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Bonacci bonacci = new Bonacci();
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("Fibonacci");
            bonacci.GerarSequenciaDeFibonacci(0,1,15);
            System.Console.WriteLine("Fatorial");
            System.Console.WriteLine(bonacci.GerarFatorial(5));
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Tribonacci");
            bonacci.GerarSequenciaDeTribonacci( 0, 1, 1, 12);
        }
    }
}
