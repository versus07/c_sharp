using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L_2_array_task_1
{
  /*Сжать массив, удалив из него все 0 и, заполнить все освободившиеся справа
   элементы значениями -1*/
    class Program
    {
        static void Main(string[] args)
        {      

            int[] Mas = new int[10];
            Mas = new int[10] {0, 1, 3, 0, 8, 9, 0, 1, 0, 2};
            //int[] Mas_2;

            MethodArr(Mas);
            Find_not_null(Mas);           
        }

        static void MethodArr(int[] Mas)
        {           
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Mas[i] + "^");
            }
            Console.WriteLine();
        }
        static void Find_not_null(int[] Mas)
        {           
            for (int i = 0; i < 10; i++)
            {
                if (Mas[i] != 0)
                {
                   // i = i + 1;
                   int Mas_2 = Mas[(i + 1)-1];
                    Console.WriteLine("[" + i + "] " + Mas[i] + " ");
                }           
            }           
        }       
    }
}
