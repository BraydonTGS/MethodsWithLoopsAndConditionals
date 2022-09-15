using System;
using static System.Console;
namespace MethodsWithLoopsAndConditionals
{
    public class World
    {
        public static void Start()
        {
            WriteLine(@" +-+-+-+-+-+ +-+ +-+-+-+-+-+-+-+-+-+-+-+-+
 |L|o|o|p|s| |&| |C|o|n|d|i|t|i|o|n|a|l|s|
 +-+-+-+-+-+ +-+ +-+-+-+-+-+-+-+-+-+-+-+-+");
            WriteLine();
            Write("Please Enter a UserName: ");
            string userName = ReadLine();
            WriteLine();
            var user = userName != "" ? userName : "Guest";
            WriteLine($"Welcome {user}!");
            WorldPrintOptions();

        }

        public static void WorldPrintOptions()
        {
            Clear();
            WriteLine(@" +-+-+-+-+-+ +-+ +-+-+-+-+-+-+-+-+-+-+-+-+
 |L|o|o|p|s| |&| |C|o|n|d|i|t|i|o|n|a|l|s|
 +-+-+-+-+-+ +-+ +-+-+-+-+-+-+-+-+-+-+-+-+");
            WriteLine();
            WriteLine("Please Select From The Following Options: ");
            WriteLine();
            WriteLine("\t> 1. LukeWarm ");
            WriteLine("\t> 2. HeatingUp ");
            WriteLine("\t> 3. Exit ");
            UserChoice(ReadLine());
            ReadKey();
        }

        public static void UserChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    LukeWarm.Start();
                    break;
                case "2":
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Clear();
                    WriteLine(@" +-+-+-+-+-+ +-+ +-+-+-+-+-+-+-+-+-+-+-+-+
 |L|o|o|p|s| |&| |C|o|n|d|i|t|i|o|n|a|l|s|
 +-+-+-+-+-+ +-+ +-+-+-+-+-+-+-+-+-+-+-+-+");
                    WriteLine();
                    WriteLine("Please Enter a Valid Choice! ");
                    WorldPrintOptions();
                    break;
            }
        }
    }
}

