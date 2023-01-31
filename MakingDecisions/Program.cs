namespace MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());


            if (age >= 18) // multiple if statments will make the computer go trough every single statement, therefore else if, which goes over to the "false" section.
            {
                Console.WriteLine("You are good to go.");
            }
            else
            {
                Console.WriteLine("Sorry, You are less than 18");
            }
        }
    }
}