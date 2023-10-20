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
            int useNumber;

            Console.WriteLine("Enter a list of positive and integer number , to Exit pleas prees -1 :");
            //get the number while the input is not -1
            do
            {
                string inputStr = Console.ReadLine();
                //check that the input is integer and positive
                if (int.TryParse(inputStr, out useNumber) && useNumber > 0)
                {
                    // Check if the entered number is greater than the current maxNumber
                    if (useNumber > maxNumber)
                    {
                        maxNumber = useNumber;
                    }
                }
                //if the input is not integer or negative is error
                else if (useNumber != -1)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            } while (useNumber != -1);

            Console.WriteLine("The largest positive integer is: " + maxNumber);
            Console.ReadLine();
        }
    }
}
