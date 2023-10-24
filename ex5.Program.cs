using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.WindowsRuntime;
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
        /// 
        static int ShowMenuOfFunction(Car car)
        {
            int actionChoice;
            int numFuncionCar = 5;
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
                numFuncionCar = 7;
            }
            Console.WriteLine("-1. Exit");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out actionChoice) || (actionChoice < 1 && actionChoice != -1) || actionChoice > numFuncionCar)
            {
                Console.WriteLine("Invalid input");
                return 0;
            }
            return actionChoice;

        }
        static void ActivatingFunction(Car car)
        {
            Lexus lexusCar = (Lexus)car;
            int chosenFunction;
            do
            {
                chosenFunction = ShowMenuOfFunction(car);
                if (chosenFunction == 0 || chosenFunction == -1)
                {
                    return;
                }
                switch (chosenFunction)
                {
                    case 1:
                        car.PrintSpeed();
                        break;
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
                    case 4:
                        Console.WriteLine("Car details:");
                        string data = car.GetData();
                        Console.WriteLine(data);
                        break;
                    case 5:
                        car.StopCar();
                        break;
                    case 6:
                        lexusCar.StartPlayingMusic();
                        break;

                    case 7:
                        lexusCar.StopPlayingMusic();
                        break;
                }
            } while (chosenFunction != -1);
        }

        static Car CreatCar(int typeCare)
        {
            Car car;
            return typeCare == 1 ? car = new Audi() : car = new Lexus();


        }
        static string ShowMenu()
        {
            Console.WriteLine("Choose a car:");
            Console.WriteLine("1. Audi");
            Console.WriteLine("2. Lexus");
            Console.WriteLine("3. Exit");
            string optionCoose = Console.ReadLine();
            return optionCoose;

        }
        static void GetCarInformation()
        {
            string userChoiceMenu;
            int actionChoiceMenu;
            do
            {
                userChoiceMenu = ShowMenu();
                if (!int.TryParse(userChoiceMenu, out actionChoiceMenu) || (actionChoiceMenu < 1 || actionChoiceMenu > 3))
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                    return;
                }
                if (actionChoiceMenu != 3)
                {
                    Car car = CreatCar(actionChoiceMenu);
                    ActivatingFunction(car);
                }

            } while (actionChoiceMenu != 3);
            Console.WriteLine("Exiting...");
            Console.ReadKey();
            return;

        }


        static void Main()
        {
            GetCarInformation();
        }
    }
}














