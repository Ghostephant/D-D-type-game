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
            // Writes the dialogue for the entrance to the game
            WriteLine("Welcome {0}, to Heck", name);
            WriteLine("Congratulations you are dead.");
            WriteLine("Down here in heck, everything is decided by the rolling of dice. Every time you need to roll a dice, say 'roll' and our magical dice demons will eagerly roll them for you");
            WriteLine("If you wish to know the circumstances with which the cessation of life has occured, say 'yes daddy please', if you wish to continue on in blissful ignorance, say 'NO GOD PLEASE NO'");
            response = ReadLine();
            // determines whether or not to write the adventurerer's death 
            if (response.Equals("yes daddy please"))
            {
                //prompts the uer to enter "roll"
                WriteLine("You have chosen rather seductively to know what caused your demise, very well.");
                WriteLine("Roll a d6");
                response = ReadLine();
                while(!response.Equals("roll"))
                {
                    WriteLine("Say 'roll'");
                    response = ReadLine();
                }
                // rolls a d6 to determine what the cause of death was
                WriteLine("You ");
                rolledNum = D6;
                if (rolledNum == 1)
                {
                    Write("tripped over your own shoelaces while walking along the road, landed on your face, breaking your neck.");
                    WriteLine("Unfortuntely that is not when you died, all that did was paralyze you, you landed in a pile of human fecal matter, which blocked your airflow, suffocating you");
                }
                if (rolledNum == 2)
                {
                    Write("tried to get #SWOLE by sticking a leaf blower in your mouth and turning it on.");
                    WriteLine("We're still not sure quite what you expected to happened but your lungs blew up inside of your chest.");
                }
                if (rolledNum == 3)
                {
                    Write("borrowed your neighbor's kid's bicycle in order to run away from the cops, but the bike was very small and you ended up getting shot in the forhead and run over thirteen times by police cruisers.");
                    WriteLine("You jay-walked.");
                }
                if (rolledNum == 4)
                {
                    Write("ate too many cupcakes at your work's annual morale-boosting-so-you-won't-want-to-jump-out-the-window-party, and had a heart attack.");
                }
                if (rolledNum == 5)
                {
                    Write("got mugged by an 87 year old woman named Beatrice. You didn't even try to fight back or anything you just let it happen, all while crying and peeing your pants in fear.");
                    WriteLine("You're actually kind of a legend down here, no one has ever responded that horribly to getting mugged by an old lady before.");
                }
                if (rolledNum == 6)
                {
                    Write("fell asleep next to your thirty three cats.");
                    WriteLine("They thought you were dead, so they ate you.");
                }
            }
            else if (response.Equals("NO GOD PLEASE NO"))
            {
                WriteLine("Golly gee alright then you didn't have to be so rude about it.");
            }
            WriteLine("Now before I continue, are you content with being dead, or do you want more out of life?");
            WriteLine("say 'yah no Im aight' or 'GIVE ME MORE'");
            response = ReadLine();
            while(!response.Equals("yah no Im aight") && !response.Equals("GIVE ME MORE"))
            {
                WriteLine("say 'yah no Im aight' or 'GIVE ME MORE'");
                response = ReadLine();
            }
            if (response.Equals("yah no Im aight"))
            {
                
            }
        }
    }
}
