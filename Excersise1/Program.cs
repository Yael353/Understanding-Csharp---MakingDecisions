using System.Security.Cryptography;

namespace Excersise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //excersice 1
            //Console.WriteLine("Enter hourly pay rate");
            //double payRate = double.Parse(Console.ReadLine());

            //if (payRate < 7.50 || payRate > 49.00)
            //{
            //    Console.WriteLine("Rate invalid");
            //}
            //else
            //{
            //    Console.WriteLine("Pay rate valid!");
            //}

            // exercise 2
            // lawn-mowing season 20 weeks
            // weekly fee under 400 25 sqrfeet.
            // fee lawn between 400-600 35.
            // fee lawn 600+ 50.
            // Weekly moving fee
            // and total fee



            //Console.WriteLine("Enter the lenght of your lawn in meters");
            //int lawnLenght = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the width of your lawn in meters");
            //int lawnWidth = int.Parse(Console.ReadLine());

            //int lawnSqr = lawnLenght * lawnWidth;
            //int pricePerWeek;

            //if (lawnSqr < 400)
            //{
            //    pricePerWeek = 25;
            //}
            //else if (lawnSqr >= 400 && lawnSqr < 600)
            //{
            //    pricePerWeek = 35;
            //}
            //else
            //    pricePerWeek = 50;


            //Console.WriteLine($"amount of square feet {lawnSqr}, weekly price: {pricePerWeek} total price for the season: {pricePerWeek * 20}");


            //Ask user to guess correct nr between 1-10.
            //too high, too low or correct.






            do
            {
                Console.WriteLine("Guess the number between 0 - 10");
                int guessedNumber = int.Parse(Console.ReadLine());
                Random randomgenerator = new Random();
                int randomNumber = randomgenerator.Next(0, 11);

                if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("The random number was {0}", randomNumber);
                    Console.WriteLine("Your guess was too low, try again!");

                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("The random number was {0}", randomNumber);
                    Console.WriteLine("Your guess was too high, try again! ");
                }
                else
                    Console.WriteLine("Congratts! you guessed correctly!");

            } while (true);




        }
    }
}