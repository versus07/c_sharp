using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа,
 * например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
 */
namespace task_3
{
    class Chislo
    {
        static void Main(string[] args)
        {
            int n, s, d, e;//s - число сотен, d - число десятков, e - число единиц
            Console.WriteLine("Введите целое число в диапазоне 100-999");
            n = Convert.ToInt32(Console.ReadLine());
            s = n / 100;
            d = n / 10 % 10;
            e = n % 10;

            switch (s)
            {
                case 1:
                    Console.Write("сто ");
                    break;
                case 2:
                    Console.Write("двести ");
                    break;
                case 3:
                    Console.Write("триста ");
                    break;
                case 4:
                    Console.Write("четыреста ");
                    break;
                case 5:
                    Console.Write("пятьсот ");
                    break;
                case 6:
                    Console.Write("шестьсот ");
                    break;
                case 7:
                    Console.Write("семьсот ");
                    break;
                case 8:
                    Console.Write("восемьмот ");
                    break;
                case 9:
                    Console.Write("девятьсот ");
                    break;
            }

            switch (d)
            {
                case 1:
                    Console.Write("десять ");
                    break;
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятьдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
                case 7:
                    Console.Write("семьдесят ");
                    break;
                case 8:
                    Console.Write("восемьдесят ");
                    break;
                case 9:
                    Console.Write("девяносто ");
                    break;
            }

            switch (e)
            {
                case 1:
                    Console.Write("один ");
                    break;
                case 2:
                    Console.Write("два ");
                    break;
                case 3:
                    Console.Write("три ");
                    break;
                case 4:
                    Console.Write("четыре ");
                    break;
                case 5:
                    Console.Write("пять ");
                    break;
                case 6:
                    Console.Write("шесть ");
                    break;
                case 7:
                    Console.Write("семь ");
                    break;
                case 8:
                    Console.Write("восемь ");
                    break;
                case 9:
                    Console.Write("девять ");
                    break;
            }
            Console.ReadKey();

        }

    }
}