using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("In order to check if number is Prime");
            Console.WriteLine("Please enter number,to Exit please press -1");
            do
            {
                string input = Console.ReadLine();
                //check if the input is integer
                if (int.TryParse(input, out userInput))
                {
                    //use the function IsPrime to check if the number is prime
                    if (IsPrime(userInput))
                    {
                        Console.WriteLine(userInput + " is primary number");
                    }
                    else
                    {
                        Console.WriteLine(userInput + " is not primary number");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                //Console.ReadLine();
            } while (userInput != -1);
        }


        // Function to check if a number is prime
        static bool IsPrime(int num)
        {
            //where num is 0, 1, or negative, which are not prime.
            if (num <= 1)
            {
                return false;
            }
            //If 'num' is divisible by 'i', it means that num' has a divisor other than 1 and itself, 
            //indicating that it is not a prime number. In this case, the function immediately returns 'false'.
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
