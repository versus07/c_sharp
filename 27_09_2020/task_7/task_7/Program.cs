using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Дано целое положительное число (N>0). вывести число в обратном порядке
 * 358->853
 */

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, a;

            Console.WriteLine("Введите целое число N ->");
            N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                a = N % 10;
                N = N / 10;
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}