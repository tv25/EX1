using System;
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
            //list that the user enter
            List<int> userList = new List<int>();
            int biggestSumList, sumList;
            Console.WriteLine("Enter a List of positive integers,press -1 to finish:");
            //add the numbers to the list untill user press -1
            while (true)
            {
                string inputStr = Console.ReadLine();
                //check that the input is valid: positive integers
                if (int.TryParse(inputStr, out int input))
                {
                    if (input == -1)
                        break;

                    if (input > 0)
                    {
                        userList.Add(input);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                }
            }
            //list to the three numbers whose sum is the largest.
            List<int> myList = new List<int>(3);
            if (userList.Count < 3)
            {
                Console.WriteLine("you enter less then 3 numbers");
            }
            else
            {
                myList.Add(userList[0]);
                myList.Add(userList[1]);
                myList.Add(userList[2]);
                biggestSumList = myList[0] + myList[1] + myList[2];
                //Go over the list that the user entered 
                //and look for each time who are the 3 consecutive numbers so that their sum is the largest
                for (int i = 3; i < userList.Count; i++)
                {
                    sumList = userList[i - 1] + userList[i - 2] + userList[i];
                    //If i found a new sequence of 3 numbers whose sum is greater
                    //We will update accordingly
                    if (sumList > biggestSumList)
                    {
                        biggestSumList = sumList;
                        myList[0] = userList[i - 2];
                        myList[1] = userList[i - 1];
                        myList[2] = userList[i];

                    }

                }

            }

            Console.WriteLine("the 3 numbers is: " + myList[0] + " " + myList[1] + " " + myList[2]);
            Console.ReadLine();
        }
    }
    }

