using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("Podaj liczbę naturalną n>1: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++) // 1
                    Console.Write(" ");

                for (j = 1; j <= i; j++)   // 2
                    Console.Write("X");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
