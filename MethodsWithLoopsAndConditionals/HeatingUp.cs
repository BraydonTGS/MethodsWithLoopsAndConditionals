using System;
using static System.Console;
namespace MethodsWithLoopsAndConditionals
{
    public class HeatingUp
    {
        public static void Start()
        {
            Clear();
            WriteLine(@" +-+-+-+-+-+-+-+-+-+
 |H|e|a|t|i|n|g|U|p|
 +-+-+-+-+-+-+-+-+-+");
            WriteLine();
            PrintOptions();
        }

        public static void PrintOptions()
        {
            Clear();
            WriteLine(@" +-+-+-+-+-+-+-+-+-+
 |H|e|a|t|i|n|g|U|p|
 +-+-+-+-+-+-+-+-+-+");
            WriteLine();
            WriteLine("Please Select From The Following Options: ");
            WriteLine();
            WriteLine("> 1. Range of -10 & 10: ");
            WriteLine("> 2. Multiply a Number by (1-12): ");
            WriteLine("> 3. Go Back: ");
            WriteLine("> 4. Exit: ");
            UserChoice(ReadLine());
            ReadKey();
        }

        public static void UserChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    InRange();
                    break;
                case "2":
                    MultiplyNumber();
                    break;
                case "3":
                    Clear();
                    World.WorldPrintOptions();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Clear();
                    WriteLine(@" +-+-+-+-+-+-+-+-+-+
 |H|e|a|t|i|n|g|U|p|
 +-+-+-+-+-+-+-+-+-+");
                    WriteLine();
                    Write("Please Enter a Valid Choice! ");
                    ReadKey();
                    WriteLine();
                    PrintOptions();
                    break;
            }
        }

        // In Range //

        public static void InRange()
        {
            double num1 = -10;
            double num2 = 10;

            WriteLine();
            Write("Plese Enter a Number: ");
            double num3;
            bool parseResults;
            parseResults = double.TryParse(ReadLine(), out num3);
            WriteLine();
            var results = (num3 >= num1 && num3 <= num2) ? $"{num3} is between {num1} & {num2}!" : $"{num3} is outside of {num1} & {num2}!";
            WriteLine(results);
            WriteLine();
            Write("Press Enter to Continue: ");
            ReadKey();
            Start();
        }


        public static void MultiplyNumber()
        {
            WriteLine();
            Write("Plese Enter a Number: ");
            double num1;
            bool parseResults;
            parseResults = double.TryParse(ReadLine(), out num1);
            WriteLine();
            var list = new List<double>();
            for (var i = 0; i <= 12; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                WriteLine($"{num1} * {item} = {num1 * item}");
                Thread.Sleep(250);
            }
            WriteLine();
            WriteLine("Wow! Thats some fast math! ");
            WriteLine();
            Write("Press Enter to Continue: ");

            ReadKey();
            Start();
        }

    }
}


