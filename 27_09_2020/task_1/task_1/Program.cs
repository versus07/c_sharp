using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double TF;
            double TC;

            Console.WriteLine("Введите число для Фаренгейта");
            TF = Convert.ToDouble(Console.ReadLine());
            if (TF == 0)
            {
                Console.WriteLine("Вы не ввели число для вычисления " + TF);
            }
            else
            {
                Console.WriteLine("По Фаренгейту это " + TF);
                TC = (TF - 32) * 5 / 9;
                Console.WriteLine("По Цельсию это " + TC);
            }
        }
    }
}
