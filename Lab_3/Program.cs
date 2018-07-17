using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "t";
            string answer = null;
            string question = "t";


            Console.WriteLine("Hello! Please enter your name:");
            string name = Convert.ToString(Console.ReadLine());


            while (repeat == "t")
            {
                Console.WriteLine(name +", please enter a number between 1 and 100:");
                int number = Convert.ToInt16(Console.ReadLine());

                while (number < 1 || number > 100)
                {
                    Console.WriteLine("Sorry " + name + ", your number is not in valid range, please try again.");
                    number = Convert.ToInt16(Console.ReadLine());
                }

                if (number % 2 != 0)
                {
                    Console.WriteLine("Your number is " + number + " and odd.");
                }
                else if (number % 2 == 0 && number < 25)
                {
                    Console.WriteLine("Your number is " + number + " and it is even and less than 25.");
                }
                else if (number % 2 == 0 && number >= 26 && number <= 60)
                {
                    Console.WriteLine("Your number is even.");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine("Your number is " + number + " and even");
                }
                else if (number % 2 != 0 && number > 60)
                {
                    Console.WriteLine("Your number is " + number + " and odd");
                }
                while (question == "t")
                {
                    Console.WriteLine(name + ", would you like to continue? (y/n)");
                    answer = Convert.ToString(Console.ReadLine());
                    answer = answer.ToLower();
                    if (answer == "y")
                    {
                        question = "t";
                        repeat = "t";
                        break;
                    }
                    else if (answer == "n")
                    {
                        question = "t";
                        repeat = "f";
                        Console.WriteLine("Thank you for picking a number, " + name + "! Have a nice day!");
                        break;
                    }
                    else if (answer != "y" && answer != "n")
                    {
                        question = "t";
                        Console.WriteLine("Please enter y or n.");
                    }
                }
            }
          


        }
    }
}
