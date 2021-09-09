using System;

namespace MyGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //random object of class rand
            var rndNumber = rand.Next(1, 20); // a range to generate a random # from
            Console.WriteLine(rndNumber);
            GuessNumber(rndNumber); //call this function GuessNumber and pass rndNumber
        }

        private static void GuessNumber(int randomNumber)
        {
            var tries = 0; // # of guesses before the correct #
            try
            {
                Console.WriteLine("Please Enter Your Guess:");
                int guess = Convert.ToInt32(Console.ReadLine()); // user input to take a guess #
                tries++;
                while(guess != randomNumber) // condition if the guessed number is != random# 
                {
                    tries++; //increament the # of tries 
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Please Try A Lower Number:"); // prompt the user to try a lower #
                        guess = Convert.ToInt32(Console.ReadLine());     
                    }
                    else if ( guess < randomNumber)
                    {
                        Console.WriteLine("Please Try A Higher Number:");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                Console.WriteLine("You Guessed It Right In {0} trials", tries); 
            }
        }
    }
}
