using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    /// <summary>
    ///Given an input which is a number the function returns its Fibonacci series 
    /// until the next number in the series is greater than the number received.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int FibonacciNumber, sum;
            Console.WriteLine("Please enter a positive number,to finish Please press -1:");
            do
            {
                string userNumber = Console.ReadLine();
                //checl if the input is integer
                if (int.TryParse(userNumber, out FibonacciNumber))
                {
                    //there is no Fibonacci series to negative numbers and 0
                    //if the user insert -1 its meen to finish
                    if (FibonacciNumber < -1 || FibonacciNumber == 0)
                    {
                        Console.WriteLine("There is no Fibonacci series to 0 or negative number");
                    }
                    else
                    {
                        List<int> myList = new List<int>(2);
                        // Add elements to the list
                        myList.Add(0);
                        myList.Add(1);
                        Console.Write(myList[0] + " ");
                        Console.Write(myList[1] + " ");
                        sum = myList[0] + myList[1];
                        //print the numbers that in the series until the next number in the series is greater than the number received
                        while (sum <= FibonacciNumber)
                        {
                            Console.Write(sum + " ");
                            myList[0] = myList[1];
                            myList[1] = sum;
                            sum = myList[0] + myList[1];
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please enter valid number");

                }

                Console.WriteLine();
            } while (FibonacciNumber != -1);

        }
    }
}
