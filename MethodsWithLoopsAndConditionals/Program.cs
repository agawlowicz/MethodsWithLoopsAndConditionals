using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            DecreasingNumbers();
            IncreaseByThree();
            Console.WriteLine(EqualityTest(3, 3));
            Console.WriteLine(EqualityTest(3, 5));
            Console.WriteLine(EvenOrOdd(3));
            Console.WriteLine(EvenOrOdd(4));
            Console.WriteLine(PositiveOrNegative(-3));
            Console.WriteLine(PositiveOrNegative(3));
            CanYouVote();
            CheckRange();
            MultiplicationTable();
            CheckRange2();
            MultiplicationTable2();
        }

        public static void DecreasingNumbers() //1000 to -1000
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void IncreaseByThree() //starting at 3 to 999
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }

        }

        public static bool EqualityTest(int x, int y)
        {
            return (x == y);
        }

        public static string EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                return $"{x} is even.";
            }
            else
            {
                return $"{x} is odd.";
            }
        }

        public static string PositiveOrNegative(int x)
        {
            return (x < 0) ? $"{x} is negative." : $"{x} is positive.";
        }

        public static void CanYouVote()
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Congrats! You can vote!");
            }
            else
            {
                Console.WriteLine("Sorry, you aren't old enough to vote.");
            }

        }

        public static void CheckRange()
        {
            Console.WriteLine("Enter integer value:");
            int integerValue = int.Parse(Console.ReadLine());
            if (integerValue >= -10 && integerValue <= 10)
            {
                Console.WriteLine($"{integerValue} is in the range -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{integerValue} is not in the range -10 to 10.");
            }
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter an integer value:");
            var enteredValue = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{enteredValue} * {i} = {enteredValue * i}");
            }
        }

        public static void CheckRange2()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer value.");
                userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse);

            if (result >= -10 && result <=10)
            {
                Console.WriteLine($"{result} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{result} is not between -10 and 10.");
            }
        }

        public static void MultiplicationTable2()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer value.");
                userResponse = int.TryParse(Console.ReadLine(), out result);

            } while (!userResponse);

            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{result} * {x} = {result * x}");
            }

        }
    }
}
