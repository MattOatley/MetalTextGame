using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace NewExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NightSide Eclipse, a text-based RPG with a Black Metal theme.");
            Console.WriteLine("You are not prepared for the horrors that lie ahead. This is not a world for the faint of heart.");
            Console.WriteLine("<================================================================================================>");
            Console.WriteLine();
            Console.WriteLine("You awaken in covered in soot and ash, you appear to be in the ruins of a burned out church. " +
                "The roof is completely gone, and the pews are burnt and mostly destroyed. You notice the crucifix, before the fire it was inverted." +
                "Something about the cross jogs your memory, you have been here before, but you cannot remember your name or who you are." +
                "Try to remember your name (Enter your name now)");
            string playerName = Console.ReadLine();

            Console.WriteLine($"{playerName} thats it! What happened here, why cant you remember anything you think to yourself." +
                $"Whatever it was it wasnt good.");
            Console.WriteLine("You pick yourself up and begin to walk out of the building, as you do you notice a few weapons strewn across the ground." +
                "You see a sword & shield, a battle axe, and a magic staff.");
            Console.WriteLine("Choose a weapon to equip by typing in the corresponding character class. " +
                "Sword & Shield-Crusader." +
                "BattleAxe-Berzerker. " +
                "Magic Staff-Sorceror");
            string playerClass = Console.ReadLine();

            Console.WriteLine($"{playerName} you have selected the {playerClass} class. Your adventure will begin soon!" +
                $"Now you must assign your attribute points");

            Console.WriteLine("First here is a brief description of each attribute:" +
                "Strength - Determines how much damage you deal with weapons" +
                "Agility - Determines how many attacks you may make each turn" +
                "Intellect - Determines which spells you can use (some spells can only be used by the sorceror)");

            Console.WriteLine("You have 20 attribute points.");
            
            Console.WriteLine("How many points would you like to add to Strength?");
            var playerStr = Console.ReadLine();

            Console.WriteLine("How many points would you like to add to Agility?");
            var playerAgi = Console.ReadLine();

            Console.WriteLine("How many points would you like to add to Intellect?");
            var playerInt = Console.ReadLine();

            Console.WriteLine($"You grip your weapon tightly as you brace yourself for whatever lies outside of the church." +
                $"You are {playerName}, and you will become a powerful {playerClass}." +
                $"As you make your way outside you realize that the rest of the town lies in ruin as well." +
                $"You begin to hope that {playerStr}, {playerAgi}, {playerInt}, is enough Strength, Agility, and Intellect to overcome the trials ahead.");

            Console.WriteLine($"As you step outside a full moon looms overhead, partially obscured by the smoke still rising from the smoldering town." +
                $"You hear a twig snap on the side of the church and you realize that you are not alone." +
                $"You see a shadowy figure appear next to the building - Well well well, what do we have here, a half dead {playerClass}? This should be easy.");
            Console.WriteLine("The figure emerges from the shadows, it is a man, but not fully human, he has long black hair, and long fingernails as sharp as razorblades." +
                "You have no choice, it is time to fight, you unsheath your weapon and the man smirks - Ah, he still has a little fight in him." +
                "Good! The meal is always more satisfying when it puts up a fight.");

            var battleOne = Encounter(playerStr);

            Console.WriteLine($"Knowing that your opponent is stronger, you seize the initiative and strike first. {battleOne}.");

            int enemyDmg1 = RandomNumber(0, 11);

            Console.WriteLine("The man stumbles in pain, but quickly regains his footing - Ha! It will take more than that to best me!");
            Console.WriteLine($"He lashes forward with his razor sharp claws, you attempt to block his attack." +
                $"The mysterious man deals {enemyDmg1} points of dmg to you");







        }

        private static object Encounter(string playerStr)
        {
            throw new NotImplementedException();
        }

        public static string Encounter(int x)
        {
            if(x >= 10)
            {
                Console.WriteLine("You deal 10 points of damage");
            }
            else
            {
                Console.WriteLine("You deal 5 points of damage");
            }
            return "You missed the target.";
        }

        private static readonly Random _random = new Random();

        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
