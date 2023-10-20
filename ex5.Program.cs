using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        /// <summary>
        /// A function that allows receiving information for vehicles.
        //The user has the option of choosing a Lexus or Audi vehicle
        //and view information or perform actions about the vehicle: viewing the vehicle's speed, 
        //stopping the car, speeding up the car and slowing down the car.
        //In addition to the Lexus car, there is an option to turn the songs on and off
        /// </summary>
        static void Car_Information()
        {
            Car car = null;
            int choice;
            //choos the car that you want to get information 
            do
            {
                Console.WriteLine("Choose a car:");
                Console.WriteLine("1. Audi");
                Console.WriteLine("2. Lexus");
                Console.WriteLine("3. Exit");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 1)
                    {
                        car = new Audi();
                    }
                    else if (choice == 2)
                    {
                        car = new Lexus();
                    }
                    else if (choice == 3)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid choice. Please select 1,2 or 3.");
                        return;
                    }
                    //In the loop, you can select and activate the available functions in any type of vehicle
                    //The loop will run as long as the user has not pressed -1
                    while (true)
                    {
                        Console.WriteLine("\nChoose an action:");
                        Console.WriteLine("1. Show Speed");
                        Console.WriteLine("2. Increase Speed");
                        Console.WriteLine("3. Slow Down the speed");
                        Console.WriteLine("4. Show car's details");
                        Console.WriteLine("5. Stop the car");
                        if (car is Lexus)
                        {
                            Console.WriteLine("6. Turn On Songs");
                            Console.WriteLine("7. Turn Off Songs");
                        }
                        Console.WriteLine("-1. Exit");
                        //ckeck that the input is integer
                        if (int.TryParse(Console.ReadLine(), out int actionChoice))
                        {
                            switch (actionChoice)
                            {
                                //case to get the car's speed
                                case 1:
                                    car.GetSpeed();
                                    break;
                                //case to increase the car's speed
                                case 2:
                                    Console.WriteLine("By how many km/h would you like to increase the speed of the car ?");
                                    if (int.TryParse(Console.ReadLine(), out int increasedSpeed))
                                    {
                                        car.IncreaseSpeed(increasedSpeed);                                     
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid input");
                                    }
                                    break;
                                //case to slow down the Car's speed
                                case 3:
                                    Console.WriteLine("By how many km/h would you like to slow down the car's speed?");
                                    if (int.TryParse(Console.ReadLine(), out int slowSpeed))
                                    {
                                        car.SlowDownSpeed(slowSpeed);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid input");
                                    }
                                    break;
                                //case to get the detils of the car :type end speed
                                case 4:
                                    Console.WriteLine("Car details:");
                                    string data = car.GetData();
                                    Console.WriteLine(data);

                                    break;
                                //case to stop the car
                                case 5:
                                    car.Stop();
                                    break;
                                //case to lexus car to turn on the songs
                                case 6 when car is Lexus lexus:
                                    lexus.StartPlayingMusic();
                                    break;
                                //case to lexus car to turn off the songs
                                case 7 when car is Lexus lexus:
                                    lexus.StopPlayingMusic();
                                    break;
                                //casr to exit
                                case -1:
                                    Console.WriteLine("Exiting...");
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Please select a valid action.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid action choice.");
                        }
                        if (actionChoice == -1)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            } while (choice != 3);
        }
        static void Main()
        {
            Car_Information();
        }
    }

}


       









