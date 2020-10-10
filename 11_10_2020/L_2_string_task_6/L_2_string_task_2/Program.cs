using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L_2_string_task_2
{

    /*determine whether the text specified as a string contains a certain word 
     * (ignore the case value)*/

    /// <summary>
    /// Find the same word in text
    /// </summary>
    /// /// <param name="args"></param>
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter some sring");
            string mas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter some word");
            string print_word = Convert.ToString(Console.ReadLine());
            mas = mas.ToLower();
            print_word = print_word.ToLower();

            for (int i = 0; i < mas.Length; i++)
            {
                string[] tempus = mas.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

               // Console.WriteLine("[" + i + "]" + tempus[i]);

                if (tempus[i] == print_word)
                {
                    Console.WriteLine("==========");
                    Console.WriteLine("This word is in the text " + print_word);
                    Console.WriteLine("==========");
                    break;
                }

                else
                {
                    if (tempus[i] != print_word)
                    {
                        Console.WriteLine("==========");
                        Console.WriteLine("This word is not in the text");
                        Console.WriteLine("==========");
                    }
                }
            }            
        }
    }
}
