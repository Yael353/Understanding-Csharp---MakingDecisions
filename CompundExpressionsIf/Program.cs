namespace CompundExpressionsIf
{
    internal class Program
    {
        // Compound expressioins, combine multiple conditions.
        // && and, || or
        static void Main(string[] args)
        {
            bool x = true;
            bool y = true;
            bool z = x && y;

            // Amd is only true when both conditions are true.
            // Or is only false íf both sides are false.

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the movie rating?");
            char rating = char.Parse(Console.ReadLine());

            if (age <= 12 || age >= 55 && rating == 'G') // checks this part first age >= 55 && rating == 'G', if not true, then checks the age <= 12 part exept with (). with && both statements must be true.
            {
                Console.WriteLine("Discount applies");
            }
            else
            {
                Console.WriteLine("There is some problem");
            }
        }
    }
}