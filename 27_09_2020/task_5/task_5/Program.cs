using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_5
{
    /* 
Задание 5. Начальный вклад в банке равен 1000 руб. Через каждый месяц размер 
вклада увеличивается на P процентов от имеющейся суммы. По данному P 
определить, через сколько месяцев размер вклада превысит 1100 руб., и вывести 
найденное количество месяцев K и итоговый размер вклада S. */

    class Program
    {
        static void Main(string[] args)
        {
            const int contribution = 1000;
            Console.WriteLine("Введите размер процентной ставки");
            double P = Convert.ToDouble(Console.ReadLine());
            double S = contribution;
            int K = 1;

            while (S < 1100)
            {
                S = S + S * P / 100;
                K++;

            }
            Console.WriteLine($"Кол-во месяцев {K} \nИтого вклада {S}");
        }
    }
}
