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
            WriteLine("\t> 1. Print Numbers 1000 to -1000: ");
            WriteLine("\t> 2. Print Numbers 3 to 999 by 3: ");
            WriteLine("\t> 3. Equal or Not: ");
            WriteLine("\t> 4. Even or Odd: ");
            WriteLine("\t> 5. Positive or Negative ");
            WriteLine("\t> 6. Can You Vote? ");
            WriteLine("\t> 7. Go Back ");
            WriteLine("\t> 8. Exit ");
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
                    break;
                case "5":
                    break;
                case "6":
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
            int num1 = int.Parse(ReadLine());
            WriteLine();
            Write("Enter Number 2: ");
            var num2 = int.Parse(ReadLine());
            WriteLine();
            string results = (num1 == num2) ? $"{num1} & {num2} are Equal! " : $"{num1} & {num2} are Not Equal!";
            WriteLine(results);
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();

        }
    }
}

