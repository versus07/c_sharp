using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L_2_array_task_2
{
    /*Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом
     * положительные (0 считать положительным)*/
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] masivkas = new int[20];
            Fill_Masivkas(masivkas);
            Sort_Masivkas(masivkas);
            Ready_Sort_Masivkas(masivkas);
                      
        }

        /// <summary>
        /// Fill our array with Rand from -20 to 20.
        /// </summary>
        /// <param name="arr">Parameter description for arr goes here.</param>

        static void Fill_Masivkas(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-20, +20);
                Console.Write(arr[i] + " ");
            }
           Console.WriteLine();
           Console.WriteLine("=============================================================");
        }

        /// <summary>
        /// Sorting array from less to more.
        /// </summary>
        /// <param name="arr">Parameter description for arr goes here.</param>
       
        static void Sort_Masivkas(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i <= arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Print our sorting array.
        /// </summary>
        /// <param name="Arr"></param>
       
        static void Ready_Sort_Masivkas(int[] arr)
        {
            for (int i = 0; i <= arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=============================================================");
        }
    }
}
