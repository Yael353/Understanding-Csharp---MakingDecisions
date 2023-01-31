using System.Security.Cryptography;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age == 1) // multiple if statments will make the computer go trough every single statement, therefore the function else if,
                          // which goes over to the "false" section, finds the first true statement and then ignores the rest.
            {
                Console.WriteLine("Your age is 1");
            }
            else if (age == 2)
            {
                Console.WriteLine("your age is 2");
            }
            else if (age == 3)
            {
                Console.WriteLine("Your age is 3");
            }
        }
    }
}