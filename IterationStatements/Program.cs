namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static bool IsThousandRange(int num)
        {
            if (num <= 100 && num >= -1000)
            {
                return true;
            }
            return false;
        } 
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreTwoNumbersEqual(int num1, int num2)
        {
            if (num1 != num2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Ayyeeee it is an even number");
            }
            else
            {
                Console.WriteLine($"It is an odd number");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num1)
        {
            if (num1 > 0)
            {
                return true;
            }
            return false;
        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool VotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes they are able to vote");
                return true;
            }
            else
            {
                Console.WriteLine($"To young to vote by {18 - age} years");
                return false;
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsInTenRange (int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }
            return false;
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            
        }
    }
}
