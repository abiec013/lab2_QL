using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programContinues = true;

            while (programContinues == true)
            {
                int userInput;
                Console.WriteLine("Please enter a number between 1 and 100");
                userInput = int.Parse(Console.ReadLine());

                if (userInput % 2 == 1)

                {
                    Console.WriteLine(userInput + " odd");
                }

                else
                {

                    if (userInput <=25)
                    {
                        Console.WriteLine(" Even and less than 25");
                    }

                    else if (userInput >= 26 && userInput <= 60)
                    {
                        Console.WriteLine("Even");
                    }

                    else
                    {
                        Console.WriteLine(userInput + " Even");
                    }

                }

               



                string userChoice;
                Console.WriteLine("Would you like to enter another number?");
                userChoice = Console.ReadLine();
                if (userChoice == "No" || userChoice == "no")
                {
                    programContinues = false;
                }









            }
        }
    }
}
