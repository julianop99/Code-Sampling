using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//namespace
namespace NumberGuesser
{
   //Main Class
    class Program
    {

        //Entry point Method
        static void Main(string[] args)
        {
            string name = "Brad Pitt";
            int age = 35;

            
            //Start Here //
            Console.WriteLine("Hello World!");
            Console.WriteLine(name);
            Console.WriteLine("Hello " +name);
            Console.WriteLine(name+ " is "+age);
            Console.WriteLine("{0} is {1}",name, age);

            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "JP";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            //Init correct number
            //int correctNumber = 7;

            //Create a new random object
            Random random = new Random();

            int correctNumber = random.Next(1,10);

            //Init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while(guess != correctNumber)
            {
                //Gets user input
                string input = Console.ReadLine();

                // Make sure it is a number
                if (!int.TryParse(input, out guess))
                {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell user it is NOT a number
                    Console.WriteLine("Please enter an actual number");

                    Console.ResetColor();

                    //Keep going
                    continue;
                }

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                if(guess != correctNumber) { 

                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell user it is the wrong number
                    Console.WriteLine("Wrong number please try again");

                    Console.ResetColor();
                }

            }

            //Output sucess message
            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Tell user it is the wrong number
            Console.WriteLine("You are correct");

            Console.ResetColor();

        }
    }
}
