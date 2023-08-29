namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            MultiplesOfThree();
            AreTheyEqual(2,6);
            EvenOrOdd(3);
            PositiveOrNegative(4);
            VotingAge(19);
            WithinRange(3);
            MultiplicationTable(2);

        }
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void MultiplesOfThree()
        {
            for (int i = 3; i <= 999; i+= 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreTheyEqual(int a , int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"That is an even number, nice work!");
            }
            else
            {
                Console.WriteLine($"Well that is just odd, get it?");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static bool PositiveOrNegative(int number1)
        {
            if (number1 > 0)
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge(int number2)
        {
            if (number2 >= 18)
            {
                Console.WriteLine($"Congratulations, you are old enough to vote!");
            }
            else
            {
                Console.WriteLine($"We apologize, but you are not old enough to vote.");
            }
        }
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool WithinRange(int number3)
        {
            if (number3 <= 10 && number3 >= -10)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int num4)
        {
            Console.WriteLine($"Multiplcation table for {num4}:");
            for (int i = 1; i <= 12; i++)
            {
                int result = num4 * i;
                Console.WriteLine($"{num4} * {i} = {result}");
            }
        }
    }
}
