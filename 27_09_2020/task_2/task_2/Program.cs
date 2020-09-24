using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_2
{
    class Treangl
    {
        /*Задание 2.  Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), 
         (x3, y3). Найти  его  периметр  и площадь,  используя  формулу  для  расстояния  между
         двумя точками на плоскости:  
         D = sqrt((x2 - x1) + (y2 - y1))
         Для  нахождения  площади  треугольника  со сторонами a,  b,  c  использовать 
         формулу Герона:
         S = (p·(p – a)·(p – b)·(p – c))1/2, 
         где p = (a + b + c)/2 — полупериметр. 
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты х1");
            double coordinates_x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты y1");
            double coordinates_y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите координаты х2");
            double coordinates_x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты y2");
            double coordinates_y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты х3");
            double coordinates_x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты y3");
            double coordinates_y3 = Convert.ToDouble(Console.ReadLine());

            double side_a = Math.Sqrt(Math.Pow((coordinates_x2 - coordinates_x1), 2) + Math.Pow((coordinates_y2 - coordinates_y1), 2));
            double side_b = Math.Sqrt(Math.Pow((coordinates_x3 - coordinates_x2), 2) + Math.Pow((coordinates_y3 - coordinates_y2), 2));
            double side_c = Math.Sqrt(Math.Pow((coordinates_x1 - coordinates_x3), 2) + Math.Pow((coordinates_y1 - coordinates_y3), 2));

            double perimeter = side_a + side_b + side_c;
            Console.WriteLine("Периметр треугольника " + perimeter);
            double half_perimeter = (side_a + side_b + side_c) / 2;
            double S = Math.Sqrt(half_perimeter * (half_perimeter - side_a) * (half_perimeter - side_b) * (half_perimeter - side_c));
            Console.WriteLine("Площадь треугольника " + S);
        }
    }
}
