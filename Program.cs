/*
Author: Daniel Niles
Date: 9/15/2020
Purpose: Using iterative statements to display a phrase
*/
using System;

namespace Niles_TechAssignment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            Console.WriteLine("Enter an integer value between 1 and 25");
            //Try statement paired with a catch to look for misinputs
            try
            {
                //Reads the users input
                string input = Console.ReadLine();
                //parses the user input to an integer
                int inputValue = int.Parse(input);
                //If statement to make sure the number is between the set limits
                if ((inputValue > 0) && (inputValue <= 25))
                {
                    Console.WriteLine("Here is a For Loop");
                    //Sets the for loop
                   for (int i = 0; i <= inputValue; i++)
                    {
                        Console.WriteLine("You have entered " + inputValue.ToString() + ". This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
            }
            //End of Try Statement

            catch
            {
                Console.WriteLine("Please enter a valid integer");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
            //End of Catch Block
        }
    }
}
