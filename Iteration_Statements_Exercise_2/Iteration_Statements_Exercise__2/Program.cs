using System;
using System.Collections.Generic;

namespace Iteration_Statements_Exercise__2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<int>() { 1, 2, 3 }; //An example collection to play around with using Loops

            ////for loop example ---> type (for) and hit Tab twice
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}



            ////foreach loop example ---> type (foreach) and hit Tab twice
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            ////while loop example ---> type (while) and hit Tab twice
            //var index = 0;
            //while (index < list.Count)
            //{
            //    Console.WriteLine(list[index]);
            //    index++;
            //}



            ////do-while loop example ---> type (do) and hit Tab twice
            //do
            //{
            //    Console.WriteLine(list[index]);
            //    index++;
            //} while (index < list.Count);



            //--------------------------------------------------------------------------------------------------------------------------------



            var numbers = new List<int>();
            int x = 0;

            //The do-while loop executes the code first then checks the conditional
            //Use a do-while loop if you need to execute code at least once

            do
            {
                x++;
                numbers.Add(x);

            } while (x < 100);


            //The while loop checks the conditional first
            //Use a while loop if you don't know how long to loop for
            //Executes code 0 or more times

            while (x < 200)
            {
                x++;
                numbers.Add(x);
            }



            Console.WriteLine("Increase:");

            //The foreach loop is used for iterating through a collection
            //Use a foreach loop if you need to go through everything in the collection from beginning to end

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Decrease:");
            Console.WriteLine();

            //The for loop is used for iterating through a collection a specific number of times
            //A for loop is more flexible than a foreach loop and allows you to iterate in many different ways

            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();
            //Console.WriteLine(numbers.Count);

















            //This While loop asks the user for a number and tells you if it's an even number or an odd number
            //uncomment this code to run it

            //int numInteger;
            //double numDouble;
            //bool conditional = true;

            //while (conditional)
            //{
            //    Console.WriteLine("please enter a number");
            //    var userInput = Console.ReadLine();

            //    if (int.TryParse(userInput, out numInteger))
            //    {
            //        if (numInteger % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an odd number");
            //            conditional = false;
            //        }
            //    }
            //    else if (double.TryParse(userInput, out numDouble))
            //    {
            //        if (numDouble % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid number");
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
