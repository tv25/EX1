using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_positive_number
{
    /// <summary>
    /// A function that accepts an input of positive integers numbers until the number -1 is entered, 
    /// and at the end returns the largest positive number.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            int currentNumber;

            Console.WriteLine("Enter a list of positive and integer number , to Exit pleas prees -1 :");
            do
            {
                string inputStr = Console.ReadLine();

                if (!(int.TryParse(inputStr, out currentNumber)) || (currentNumber <= 0 && currentNumber != -1))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    return;

                }
                else if (currentNumber != -1)
                {
                    if (currentNumber > maxNumber)
                    {
                        maxNumber = currentNumber;
                    }

                }
            } while (currentNumber != -1);

            Console.WriteLine(maxNumber != 0 ? $"The largest positive integer is: {maxNumber}" : "You didn't insert anything ");
            Console.ReadLine();
        }
    }
}
