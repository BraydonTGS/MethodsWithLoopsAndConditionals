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
            Thread.Sleep(1000);
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
            WriteLine("> 1. LukeWarm: ");
            WriteLine("> 2. HeatingUp: ");
            WriteLine("> 3. Exit: ");
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
                    HeatingUp.Start();
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
                    Write("Please Enter a Valid Choice! ");
                    ReadKey();
                    WriteLine();
                    WorldPrintOptions();
                    break;
            }
        }
    }
}

