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

            int FibonacciNumber, sumMembersOfFibonacci;
            Console.WriteLine("Please enter a positive number:");
            string userNumber = Console.ReadLine();
            if (!(int.TryParse(userNumber, out FibonacciNumber)) || FibonacciNumber <= 0)
            {
                Console.WriteLine("invalid input");
                Console.ReadLine();
                return;
            }
            List<int> membersOfFibonacci = new List<int>() { 0, 1 };
            Console.Write("{0} {1}", membersOfFibonacci[0], membersOfFibonacci[1]);
            sumMembersOfFibonacci = membersOfFibonacci[0] + membersOfFibonacci[1];

            while (sumMembersOfFibonacci <= FibonacciNumber)
            {
                Console.Write(" " + sumMembersOfFibonacci);
                membersOfFibonacci[0] = membersOfFibonacci[1];
                membersOfFibonacci[1] = sumMembersOfFibonacci;
                sumMembersOfFibonacci = membersOfFibonacci[0] + membersOfFibonacci[1];
            }
            Console.ReadLine();
        }
    }
}



