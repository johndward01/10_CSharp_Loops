using System;
using System.Collections.Generic;

namespace Iteration_Statements_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            ////for loop example ---> type (for) and hit Tab twice
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();




            //var list = new List<int>() { 1, 2, 3 }; //An example List<int> (a list of integers) to play around with using Loops

            //foreach (var number in list)
            //{
            //    Console.WriteLine(number);
            //}





            ////another for loop example using the list above
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();












            ////foreach loop example ---> type (foreach) and hit Tab twice
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();

            ////while loop example ---> type (while) and hit Tab twice
            //var index1 = 0;
            //while (index1 < list.Count)
            //{
            //    Console.WriteLine(list[index1]);
            //    index1++;
            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();

            ////do-while loop example ---> type (do) and hit Tab twice
            //var index2 = 0;
            //do
            //{
            //    Console.WriteLine(list[index2]);
            //    index2++;
            //} while (index2 < list.Count);
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();

            ////--------------------------------------------------------------------------------------------------------------------------------

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//An example int[] (an array of integers) to play around with using Loops

            ////TODO --> Use a foreach loop to print each number to the console
            //foreach (var number in arr)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();

            ////TODO --> Use a for loop to print only the EVEN numbers            
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }                
            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();

            //TODO --> Using a while loop, print out to the console "This is not the number you're looking for" 10 times

            //Create an integer variable and initialize it to 0


            //while (true)
            //{
            //    var favnumber = 10;
            //     //we need to increment x otherwise we will have an infinite loop because the condition (x < 10) will always be true
            //    Console.Write($"Try to guess the number: ");
            //    var guess = int.Parse(Console.ReadLine());
            //    if (guess == favnumber)
            //    {
            //        Console.WriteLine("Congratulations!");
            //        break;
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();

            ////TODO --> Using a do-while loop, ask the user for their favorite number then print out that number 10 times

            //Create an integer variable and initialize it to 0;
            int y = 0;

            Console.WriteLine("What is your favorite number?");
            var favoriteNumber = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(favoriteNumber);
                y++;
            } while (y < 10);
            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine();
        }
    }
}
