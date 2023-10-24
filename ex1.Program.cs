using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    /// <summary>
    ///  A function that accepts a number and returns true if it is prime, or false if not
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Please enter a number");           
            string input = Console.ReadLine();
            if (!(int.TryParse(input, out userInput)))
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                return;

            }
             Console.WriteLine("{0} is {1} primary number", userInput, (IsPrime(userInput) ? "" : "not")); 
            Console.ReadKey();

        }
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }           
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
