using System;
using System.Net.Cache;

namespace IterationStatements
{
    public class Program
    {
      
      //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000
            NewPrint();
            PrintByThree();
            CheckEqual(3, 3);
            EvenOrOdd();
            NegOrPos();
            AbleToVote();
            BetweenNum();
            MultipTable(3);


        }
        public static void NewPrint()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThree()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckEqual(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
                
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }


        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter your number: ");
            var YourNum = int.Parse(Console.ReadLine());
            if (YourNum % 2 == 0)
            {
                Console.WriteLine("Number is even");       
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

        }

        //Check if Positive or Negative
        public static void NegOrPos()
        {
            Console.WriteLine("Enter your number: ");
            var YourNum = int.Parse(Console.ReadLine());
            if (YourNum < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else if (YourNum == 0)
            {
                Console.WriteLine("Niether");
            }

            else
            {
                Console.WriteLine("Number is Positive");
            }
        }

        //Able to vote/Not
        public static void AbleToVote()
        {
            Console.WriteLine("Enter your age: ");
            var Age = int.Parse(Console.ReadLine());
            if(Age >= 18)
            {
                Console.WriteLine("Congratulation! You are able to Vote!");
            }
            else
            {
                Console.WriteLine("Sorry, You are not able to Vote");
            }
        }

        //check if an integer is between -10 and 10
        public static void BetweenNum()
        {
            Console.WriteLine("Enter a number");
            var YourNum = int.Parse(Console.ReadLine());
            if (YourNum >= -10 && YourNum <= 10)
            {
                Console.WriteLine("Your number is in range");
            }
            else
            {
                Console.WriteLine("Not in range");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultipTable(int num)
        {
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine($"{i} multiplied by {num} = {num * i}");
            }
        }


    }
}
