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
            Console.WriteLine("4 - go to Land");
            Console.WriteLine("5 - speed up");


            char enter_some_sign = 'z';
            while (enter_some_sign != 'q')
            {
                enter_some_sign = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"You push button - {enter_some_sign}");

                int task_for_satellite = Convert.ToInt32(Console.ReadLine());

                switch (task_for_satellite)
                {
                    case 1:
                        {
                           // Console.WriteLine("If satellite in space push - 1");
                            //Console.WriteLine("If satellite is Landing push - 0");
                            satellite.GoToSpace(1);
                            //satellite.GetInfo();
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
                    case 5:
                        {
                            int speed_satellite = 0;
                            Console.WriteLine("Enter your beginer speed");
                            int speed_user = Convert.ToInt32(Console.ReadLine());
                            speed_satellite = satellite.Speed_up(speed_user);
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
        private int speed_up;

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

        public void GoToSpace(int if_fly)
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
                Console.WriteLine("We have not broadcast yeat");
            }
        }

        public int Speed_up(int speed_from_user)
        {
            this.speed_up = speed_from_user;

           int first_speed = 0;
                for (int i = 0; i < 300; i++)
                {

                first_speed = first_speed + speed_from_user;
                Console.WriteLine(first_speed + " ");
                }

            return first_speed;
        }
    }
}

