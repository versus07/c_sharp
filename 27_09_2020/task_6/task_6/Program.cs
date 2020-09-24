using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Даны целые положительные числа от А до В (A<B). Вывести все числа от А до В ключительно;
 * Каждое число должно выводится в новой строке столько раз, какое значение числа.
 * 3 3 3
 * 4 4 4 4
 * 5 5 5 5
 * 6 6 6 6 6
 */

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Введите числа А и В (A<B)");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=================================");
            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
