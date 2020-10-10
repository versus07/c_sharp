using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L_2_string_task_1
{
    class Program
    {
        /*Use the keyboard to enter a string of any length and calculate the percentage of occurrence
         * of vowels of the Latin alphabet in the string (without distinguishing between cases)*/

        /// <summary>
        /// we count how many vowels, and show it's in percent.
        /// Find vowels, count it and find percentage of occurense
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           Console.WriteLine("Inter some string");

           string str = Convert.ToString(Console.ReadLine());
           str = str.ToLower();           

             Console.WriteLine("Your string is: " + str);

             int count = 0;

             for (int i = 0; i < str.Length; i++)
             {
                 char [] mas_c = str.ToCharArray();
                
                Console.WriteLine("[" + mas_c[i] + "]");
                 

                 if (mas_c[i] == 'a' || mas_c[i] == 'o' || mas_c[i] == 'u' || mas_c[i] == 'e' || mas_c[i] == 'i' || mas_c[i] == 'y')
                 {
                     count++;
                 }

                 else
                 {
                     continue;
                 }                
             }

                 Console.WriteLine("Sam of vowels is " + count);

            int percent_enter = (count * 100) / str.Length;
            Console.WriteLine("percentage occurrence of the vowel " + percent_enter + "%");

        }
    }
}
