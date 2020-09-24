using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону прямоугольника а");
            double side_pramoygol_a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону прямоугольника b");
            double side_pramoygol_b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата");
            double side_square = Convert.ToDouble(Console.ReadLine());

            
            if (side_pramoygol_a < side_square || side_pramoygol_b < side_square)
            {
                Console.WriteLine("Одна из сторон квадрата или обе больше прямоугольника");

            }
            else
            {
                double col_squares_side_a = side_pramoygol_a / side_square;
                double col_squares_side_b = side_pramoygol_b / side_square;
                double col_squares = col_squares_side_a * col_squares_side_b;
                double S_pramougol = side_pramoygol_a * side_pramoygol_b;
                double S_square = 4 * side_square;
                double S_square_all = S_square * col_squares;
                double ostatok = S_pramougol - S_square_all;

                Console.WriteLine("Всего квадратов " + col_squares);
                Console.WriteLine("Остаток " + ostatok);

            }
        }
    }
}
