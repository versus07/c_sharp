using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_space
{   
    class Program
    {
        static void Main(string[] args)
        {
            var satellite = new Satellite();

            Console.WriteLine("If you are enter:");
            Console.WriteLine("1 - go to space");
            Console.WriteLine("2 - start broadcast");
            Console.WriteLine("3 - stop broadcast");
            Console.WriteLine("1 - go to Land");


            char enter_some_sign = 'z';
            while (enter_some_sign != 'q')
            {
                enter_some_sign = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Вы нажали клавишу - {enter_some_sign}");

                int task_for_satellite = 0;
                task_for_satellite = Convert.ToInt32(Console.ReadLine());

                switch (task_for_satellite)
                {
                    case 1:
                        {
                            satellite.GoToSpace();
                            satellite.GetInfo();
                            break;
                        }
                    case 2:
                        {
                            satellite.StartBroadcast();
                            satellite.GetInfo();
                            break;
                        }
                    case 3:
                        {
                            satellite.StopBroadcast();
                            satellite.GetInfo();
                            break;
                        }
                    case 4:
                        {
                            satellite.GoToLand();
                            satellite.GetInfo();
                            break;
                        }
                }              
            
            }            
        }
    }

    public class Satellite
    {
        private string name;
        private double speed;
        private bool isFly;
        private bool isBroadcast;
        private string message;

        public Satellite()
        {
            name = "Apolonchic-2";
            speed = 300;
            isFly = false;
            isBroadcast = false;
            message = "I satellite, Hi!";
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Is Fly: {isFly}");
            Console.WriteLine($"Is translate: {isBroadcast}");
            Console.WriteLine($"Message: {message}");
        }

        public void GoToSpace()
        {
            if(isFly)
            {
                Console.WriteLine("Satellite in space now");
            }
            else
            {
                Console.WriteLine("Satellite is landing now");
                isFly = true;
            }
        }

        public void GoToLand()
        {
            if (isFly)
            {
                Console.WriteLine("OK, Satellite go home");
            }
            else
            {
                Console.WriteLine("Satellite is already on the ground");
                
            }
        }

        public void StartBroadcast()
        {
            if(isBroadcast)
            {
                Console.WriteLine("We've already started broadcasting");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(message);
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }

        public void StopBroadcast()
        {
            if (isBroadcast)
            {
                Console.WriteLine("Ok, Stop Broadcast!!!");
                isBroadcast = false;
            }
            else
            {
                Console.WriteLine("We havw not broadcast yeat");
            }
        }
    }
}

