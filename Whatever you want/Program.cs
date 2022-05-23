using System;
using static System.Console;
namespace Whatever_you_want
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            int rolledNum;
            WriteLine("Welcome Adventurer, to Heck");
            WriteLine("Congratulations you are dead.");
            WriteLine("If you wish to know the circumstances with which the cessation of life has occured, say 'yes daddy please', if you wish to continue on in blissful ignorance, say 'NO GOD PLEASE NO'");
            response = ReadLine();
            if (response.Equals("yes daddy please"))
            {
                rolledNum = Roll.D6;

            }
            else if (response.Equals())
        }
    }
}
