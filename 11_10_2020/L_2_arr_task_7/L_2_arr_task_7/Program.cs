using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*given an array of integers containing n elements. For testing, provide the ability to set array 
 * elements in different ways: when describing with initialization, assigning values (including 
 * random ones), or entering the required values 1.Get elements that occur more than once in the 
 * array without repeating 2. Find the 5 largest values in an integer array in one view*/

namespace L_2_arr_task_7
{
    class Program
    {
        /// <summary>
        /// Sorting our array and show the last five, becouse they are bigest from all array
        /// </summary>
        /// <param name="arr"></param>
        static void Arsort(int[] arr)
        {
            Array.Sort(arr);

            Console.WriteLine("5 highest values:");
            for (int i = 5; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        /// <summary>
        /// find digit that repead in the array.
        /// </summary>
        /// <param name="arr_1"></param>
        static void Same_var(int[] arr_1)
        {                     

            for (int i = 0; i < arr_1.Length; i++)
            {
                if (Array.IndexOf(arr_1, arr_1[i], i + 1) != -1)
                {               

                   Console.WriteLine(arr_1[i] + " same digit");
                    
                }                   
            }            
        }

        /// <summary>
        /// in main function we are choose the methot that fill our array.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("if the array is initialized by uniform enter - 1, from the keyboard enter - 2, if with random - 3");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    {
                        Console.WriteLine("Your chose 1");

                        int[] arr = new int[10] { 2, 3, 9, 7, 1, 8, 3, 2, 5, 4 };

                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr[i] + " ");
                        }
                        Console.WriteLine("-------------------");

                        Arsort(arr);

                        Console.WriteLine();
                        Console.WriteLine("-------------------");

                        Same_var(arr);

                        break;
                    }
                case 2:

                    {
                        Console.WriteLine("Your chose 2");
                        Console.WriteLine("Fill array with 10 digit!");
                        int[] arr = new int[10];

                        for (int i = 0; i < 10; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                            //Console.Write(Arr[i] + " ");
                        }
                        Console.WriteLine("-------------------");

                        Arsort(arr);

                        Console.WriteLine();
                        Console.WriteLine("-------------------");

                        Same_var(arr);

                        break;
                    }

                case 3:
                    {
                        int[] arr = new int[10];
                        Random rand = new Random();
                        Console.WriteLine("Your chose 3");
                        Console.WriteLine("Its fill with random");

                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = rand.Next() % 10;
                            Console.WriteLine(arr[i] + " ");
                        }
                        Console.WriteLine("-------------------");

                        Arsort(arr);

                        Console.WriteLine();
                        Console.WriteLine("-------------------");

                        Same_var(arr);

                        break;
                    }
            }

        }
    }
}
    

