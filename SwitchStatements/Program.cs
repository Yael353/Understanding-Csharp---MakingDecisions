namespace SwitchStatements
{
    internal class Program
    {
        // Switch statement exact conditions, not less or greater than statements. 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());

            //if (year == 1)
            //{
            //    Console.WriteLine("Freshman");
            //}
            //else if (year == 2)
            //{
            //    Console.WriteLine("Sophomore");
            //}
            //else if (year == 3)
            //{
            //    Console.WriteLine("Junior");
            //}
            //else if (year == 4)
            //{
            //    Console.WriteLine("Senior");
            //}
            //else
            // Console.WriteLine("Invalid year");

            switch (year)
            {
                case 1:
                    {
                        Console.WriteLine("Freshman");
                        break; // leaves the switch sections and continues on with the coming code.   
                    } // No currleybrackets will make this as an or statements, where case 1 and case 2 would return "sophomore"
                case 2:
                    {
                        Console.WriteLine("Sophomore");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Junior");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Senior");
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Invalid year");
                        break;
                    }
            }
        }
    }
}