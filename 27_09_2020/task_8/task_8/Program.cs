using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*1.	Определить, есть ли среди первых четырех цифр дробной части заданного 
 * положительного вещественного числа, цифра 5   */

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double Val = GetValue();
            
            double F_f_n = Only_fractional_part(Val);

            double digit = Four_fractional_number(F_f_n);

            int digit_2 = Four_number(digit);

            int count_5 = 0;
            for (int i=0;i<4;i++)
            {
                int j = digit_2 % 10;
                if (j==5)
                {
                    count_5++;
                }
                digit_2 = digit_2 / 10;
            }
            if (count_5>0)
            {
                Console.WriteLine("Есть цифра 5!");
            }
            else
            {
                Console.WriteLine("Нет цифры 5!");
                    }
            Console.WriteLine();
            //Console.ReadLine();
        }
        
        /// <summary>
        /// Получить значение от пользователя
        /// </summary>
        /// <returns>Введённое значение</returns>
        static double GetValue()
        {
            Console.Write("Введите вещественное число Val -> ");
            double Val = Convert.ToDouble(Console.ReadLine());
            return Val;
        }

        /// <summary>
        /// Через формулу отбрасываем целую часть, остается дробная
        /// </summary>
        /// <param Only_fractional_part ="Val">Значение</param>
        static double Only_fractional_part(double Val)
        {
            
            Val = Val - (int)Val;
            
            Console.WriteLine("1 " + Val);
          
            return Val;
        }
        
        /// <summary>
        /// В целую часть переносим четыре числа из дробной части
        /// </summary>
        /// <param Four_fractional_number="F_f_n">Значение</param>
        
        static double Four_fractional_number(double F_f_n)
        {

            F_f_n = F_f_n * 10000;

            Console.WriteLine("2 " + F_f_n);
            return F_f_n;
        }

        /// <summary>
        /// Избасляемся от остальной дробной части
        /// </summary>
        /// <param Four_number="Val_3">Значение</param>

        static int Four_number(double Val_2)
        {

            int Val_3 = Convert.ToInt32(Math.Truncate(Val_2));

            Console.WriteLine("3 " + Val_3);
            return Val_3;
        }
    }
}
