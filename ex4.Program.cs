using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_sum_largest
{
    /// <summary>
    /// The function receives an input of positive integers until the number 1- 
    /// is received and at the end prints the sequence of the three numbers whose sum is the largest.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersReceived = new List<int>();
            int biggestSum, currentSum, userInput;
            Console.WriteLine("Enter a List of positive integers,press -1 to finish:");
            do
            {
                string inputStr = Console.ReadLine();
                if (!int.TryParse(inputStr, out userInput) || (userInput <= 0 && userInput != -1))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    return;
                }
                if (userInput != -1)
                {
                    numbersReceived.Add(userInput);
                }

            } while (userInput != -1);


            List<int> numbersWithLargestSum = new List<int>(3);
            if (numbersReceived.Count < 3)
            {
                Console.WriteLine("you enter less then 3 numbers");
                Console.ReadKey();
                return;
            }
            numbersWithLargestSum = numbersReceived.GetRange(0, 3);
            biggestSum = numbersWithLargestSum.Take(3).Sum();
            for (int i = 3; i < numbersReceived.Count; i++)
            {
                currentSum = numbersReceived.GetRange(i - 2, 3).Sum();
                //currentSum = numbersReceived.Skip(i - 2).Take(3).Sum();

                if (currentSum > biggestSum)
                {
                    numbersWithLargestSum = numbersReceived.GetRange(i - 2, 3);

                }

            }

            Console.WriteLine("The 3 numbers is: " + string.Join(" ", numbersWithLargestSum.GetRange(0, 3)));
            Console.ReadKey();
            return;
        }
    }
}


