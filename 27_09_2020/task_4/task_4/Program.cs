using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Даны целые положительные числа A, B, C. Значение этих чисел программа должна запрашивать у пользователя.
 * На прямоугольнике размера A * B размещено максимально возможное количество квадратов со стороной C.
 * Квадраты не накладываются друг на друга. Найти количество квадратов, размещенных на прямоугольнике,
 * а также площадь незанятой части прямоугольника.
 * Необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя разместить ни
 * одного квадрата со стороной С
 */
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Введите размеры прямоугольника A и B ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размеры квадрата C ");
            C = Convert.ToInt32(Console.ReadLine());
            int s = A * B;
            int kolvo_kv = s / Convert.ToInt32(Math.Pow(C, 2));
            int s_nazanyato = s % Convert.ToInt32(Math.Pow(C, 2));
            Console.WriteLine($"В прямоугольнике размером {A}x{B} можно разместить {kolvo_kv} квадратов со стороной {C}");
            Console.WriteLine($"Площадь незанятая - {s_nazanyato}");


        }
    }
}