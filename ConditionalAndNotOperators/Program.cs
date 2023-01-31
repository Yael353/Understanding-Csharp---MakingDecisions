namespace ConditionalAndNotOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////if-statement on the fly
            ////(condition)? true : false

            //int x = 50;
            //int y = 16;

            //int biggestNumber = x > y ? x : y; // Can be used anywhere you need to get a value.
            //Console.WriteLine(biggestNumber);

            //double testscore = 95;
            //Console.WriteLine(testscore >= 60 ? "It is greater or equal to 60" : "It is not greater than 60");

            //int myBool = 5;
            //if (!(myBool >= 6 )) // this says if myBool is not greater or equal to 6. 
            //{

            //}


            bool value = true && false;
            Console.WriteLine(value);
        }
    }
}