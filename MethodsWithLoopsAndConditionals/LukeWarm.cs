using System;
using static System.Console;
namespace MethodsWithLoopsAndConditionals
{
    public class LukeWarm
    {
        // LukeWarm //

        public static void Start()
        {
            Clear();
            WriteLine(@" +-+-+-+-+-+-+-+-+
 |L|u|k|e|W|a|r|m|
 +-+-+-+-+-+-+-+-+");
            WriteLine();
            PrintOptions();
        }

        public static void PrintOptions()
        {

            WriteLine("Please Select From The Following Options: ");
            WriteLine();
            WriteLine("> 1. Print Numbers 1000 to -1000: ");
            WriteLine("> 2. Print Numbers 3 to 999 by 3: ");
            WriteLine("> 3. Equal or Not Equal: ");
            WriteLine("> 4. Positive or Negative: ");
            WriteLine("> 5. Even or Odd: ");
            WriteLine("> 6. Can You Vote? ");
            WriteLine("> 7. Go Back: ");
            WriteLine("> 8. Exit: ");
            UserChoice(ReadLine());
            ReadKey();
        }
        public static void UserChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    PrintNumbers();
                    break;
                case "2":
                    PrintByThree();
                    break;
                case "3":
                    EqualOrNot();
                    break;
                case "4":
                    PositiveOrNegative();
                    break;
                case "5":
                    EvenOrOdd();
                    break;
                case "6":
                    CanYouVote();
                    break;
                case "7":
                    Clear();
                    World.WorldPrintOptions();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
                default:
                    Clear();
                    WriteLine(@" +-+-+-+-+-+-+-+-+
 |L|u|k|e|W|a|r|m|
 +-+-+-+-+-+-+-+-+");
                    WriteLine();
                    WriteLine("Please Enter a Valid Choice! ");
                    PrintOptions();
                    break;
            }
        }

        // Numbers 1000 to -1000
        public static void PrintNumbers()
        {
            for (var i = 1000; i >= -1000; i--)
            {
                WriteLine($"{i} I am getting smaller!!!");
                Thread.Sleep(20);
            }
            WriteLine();
            WriteLine("This is A LOT of Numbers ");
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();
        }

        // Numbers 3 to 999 by 3 //
        public static void PrintByThree()
        {
            for (var i = 3; i <= 999; i += 3)
            {
                WriteLine($"{i} I am getting bigger!!!");
                Thread.Sleep(20);
            }
            WriteLine();
            WriteLine("This is A LOT of Numbers ");
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();
        }

        // Equal or Not //
        public static void EqualOrNot()
        {
            WriteLine();
            WriteLine("Plese Enter two numbers");
            WriteLine();
            Write("Enter Number 1: ");
            int num1;
            bool parseResults;
            parseResults = int.TryParse(ReadLine(), out num1);
            WriteLine();
            Write("Enter Number 2: ");
            int num2;
            parseResults = int.TryParse(ReadLine(), out num2);
            WriteLine();
            string results = (num1 == num2) ? $"{num1} & {num2} are Equal! " : $"{num1} & {num2} are Not Equal!";
            WriteLine(results);
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();
        }

        // Positive Or Negative //
        public static void PositiveOrNegative()
        {
            WriteLine();
            Write("Plese Enter a Positive or Negative number: ");
            double num1;
            bool parseResults;
            parseResults = double.TryParse(ReadLine(), out num1);
            if (num1 == 0)
            {
                WriteLine();
                WriteLine($"{num1} is neither Positive or Negative! ");
                WriteLine();
                Write("Press Enter to Continue: ");
                ReadKey();
                Start();
            }
            WriteLine();
            string results = (num1 < 0) ? $"{num1} is a Negative Number!" : $"{num1} is a Positive Number";
            WriteLine(results);
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();
        }
        // Even or Odd //
        public static void EvenOrOdd()
        {
            WriteLine();
            Write("Plese Enter a Number: ");
            double num1;
            bool parseResults;
            parseResults = double.TryParse(ReadLine(), out num1);
            WriteLine();
            string results = ((num1 % 2) == 0) ? $"{num1} is Even!!!" : $"{num1} is Odd!!!";
            WriteLine(results);
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();
        }
        // Can You Vote //
        public static void CanYouVote()
        {
            WriteLine();
            Write("Plese Enter your age: ");
            double num1;
            bool parseResults;
            parseResults = double.TryParse(ReadLine(), out num1);
            WriteLine();
            string results = (num1 >= 18) ? "You are old enought to vote!!!" : "You are not old enough to vote";
            WriteLine(results);
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();
        }
    }
}

