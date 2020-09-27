using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sayi,b;
            Console.WriteLine("sayi");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= sayi; i++)
            {
                for (j = 1; j <= sayi; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("\t");
                for (b = 1; b <= i; b++)
                {
                    Console.Write(" ");
                }
            }

            Console.ReadLine();
        }
    }
}
