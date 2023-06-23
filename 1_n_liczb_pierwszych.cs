using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1liczbypierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int ilosc = int.Parse(Console.ReadLine());
            int zapisane     = 0;
            for (int i = 2; zapisane < ilosc; i++)
            {
                Boolean sprawdz = CzyPierwsza(i);
                if (sprawdz == true)
                {
                    Console.WriteLine(i);
                    zapisane++;
                }
                else
                {
                    continue;
                }
            }


            Console.ReadKey();
        }

        static Boolean CzyPierwsza(int i)
        {
            int j = 2;
            while (j != i)
            {
                if (i % j == 0)
                {
                    return false;
                }
                else if (j % i != 0)
                {
                    j++;
                    continue;

                }

            }
            return true;
        }
    }
}
