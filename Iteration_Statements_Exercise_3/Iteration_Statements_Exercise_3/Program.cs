using System;
using System.Collections.Generic;

namespace Iteration_Statements_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Print1000();

            // 2
            //var listOfThrees = PrintBy3();

            //foreach (var number in listOfThrees)
            //{
            //    Console.WriteLine(number);
            //}

            // 3
            //EqualOrNot(4, 4);

            // 4
            //IsEvenOrOdd(2);

            // 5
            //IsPositiveOrNegative(-1);

            // 6
            //CanVote();

            // 7
            //InRange(11);

            // 8
            MultiplicationTable(10);

            // 9
            //var collection = ArrayOfIndexers(7);
            //foreach (var number in collection)
            //{
            //    Console.WriteLine(number);
            //}

            // 10
            //int[] array = new int[3];
            //array[0] = 14;
            //array[1] = 13;
            //array[2] = 12;            
            //Console.WriteLine(ComputeSumOfArray(new int[] { 1, 2, 3, 4, 5, 6 }));
            //Console.WriteLine(ComputeSumOfArray(array));

            // 11
            //CubedNumber(5);


        }

        // LUKE WARM

        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }            
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static List<int> PrintBy3()
        {
            var list = new List<int>();

            for (int i = 3; i <= 999; i+=3)
            {
                list.Add(i);
            }
            return list;
        }

        public static void Printby3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void EqualOrNot(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is not equal to y");
            }
        }

        //Write a method to check whether a given number is even or odd.
        public static void IsEvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("this number is even");
            }
            else
            {
                Console.WriteLine("this number is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative.
        public static void IsPositiveOrNegative(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("this number is positive");
            }
            else if (x < 0)
            {
                Console.WriteLine("this number is negative");
            }
            else
            {
                Console.WriteLine("this number is zero");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void CanVote()
        {
            int num;
            
            Console.WriteLine("Please enter your age");
            var userInput = Console.ReadLine();
            var age = int.TryParse(userInput, out num);
            if (age)
            {
                if (num >= 18)
                {
                    Console.WriteLine("You are old enough to vote");
                }
                else
                {
                    Console.WriteLine("you are not old enough to vote");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }            

        }

        // HEATIN UP

        //Write a method to check if an integer (from the user) is in the range -10 to 10.
        public static void InRange(int userInput)
        {
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("the number is in the range of 10 <--> -10");
            }
            else
            {
                Console.WriteLine("the number is not in the range of 10 <--> -10");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        //Write a method that takes a number from the user and returns an array with that many indexes. The values shall be random numbers.
        public static int[] ArrayOfIndexers(int number)
        {
            int[] arr = new int[number];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 100);
            }
            return arr;
        }

        //Write a method to compute the sum of all the elements in an array of integers.
        static int ComputeSumOfArray(int[] arr)
        {
            //return arr.Sum();

            int sum = 0;

            foreach (var item in arr)
            {
                //sum = sum + item;
                sum += item;
            }
            return sum;
        }

        //Write a method to display the cube of the number up to given an integer.    
        //If a user inputs the number 3 the method should print to the console: 
        //Number is: 1 and the cube of 1 is: 1, Number is: 2 and the cube of 2 is: 8, Number is: 3 and the cube of 3 is: 27
        public static void CubedNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Number is: {i} and the cube of {i} is {i * i * i}");
            }
        }
    
    }
}
