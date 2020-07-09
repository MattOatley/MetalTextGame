using System;
using System.Collections.Generic;
using System.Text;

namespace NewExercise
{
    public class Introduction : Player
    {
        Player characterInfo = new Player();

        public static void Intro()
        {
            Console.WriteLine("Welcome to NightSide Eclipse, a text-based RPG with a Black Metal theme.");
            Console.WriteLine("You are not prepared for the horrors that lie ahead. This is not a world for the faint of heart.");
            Console.WriteLine("<================================================================================================>");
            Console.WriteLine();
            Console.WriteLine("You awaken in covered in soot and ash, you appear to be in the ruins of a burned out church. " +
                "The roof is completely gone, and the pews are burnt and mostly destroyed. You notice the crucifix, before the fire it was inverted." +
                "Something about the cross jogs your memory, you have been here before, but you cannot remember your name or who you are." +
                "Try to remember your name (Enter your name now)");
            
        }

        public void CharacterCreation()
        {
            Console.WriteLine($"{characterInfo.PlayerChar} thats it! What happened here, why cant you remember anything you think to yourself." +
               $"Whatever it was it wasnt good.");
            Console.WriteLine("You pick yourself up and begin to walk out of the building, as you do you notice a few weapons strewn across the ground." +
                "You see a sword & shield, a battle axe, and a magic staff.");
            Console.WriteLine("Choose a weapon to equip by typing in the corresponding character class.");

            Console.WriteLine("***************************");
            Console.WriteLine("Sword & Shield -- Crusader.");
            Console.WriteLine("**************************");
            Console.WriteLine("BattleAxe -- Berzerker.");
            Console.WriteLine("**************************");
            Console.WriteLine("Magic Staff -- Sorceror");
            Console.WriteLine("**************************");
            characterInfo.CharClass = Console.ReadLine();

            Console.WriteLine($"{characterInfo.PlayerChar} you have selected the {characterInfo.CharClass} class. Your adventure will begin soon!" +
                $"Now you must assign your attribute points");

            Console.WriteLine("First here is a brief description of each attribute:");
            Console.WriteLine("Strength - Determines how much damage you deal with weapons");
            Console.WriteLine("<===========================================================>");
            Console.WriteLine("Agility - Determines how many attacks you may make each turn");
            Console.WriteLine("<===========================================================>");
            Console.WriteLine("Intellect - Determines which spells you can use (some spells can only be used by the sorceror)");

            Console.WriteLine("You have 20 attribute points.");

            Console.WriteLine("How many points would you like to add to Strength?");
            characterInfo.CharStr = int.Parse(Console.ReadLine());

            Console.WriteLine("How many points would you like to add to Agility?");
            characterInfo.CharAgi = int.Parse(Console.ReadLine());

            Console.WriteLine("How many points would you like to add to Intellect?");
            characterInfo.CharInt = int.Parse(Console.ReadLine());
            //Add stamina, possibly take away intellect?

            characterInfo.PlayerHP = 100;

            Console.WriteLine($"You have {characterInfo.CharStr} Strength, {characterInfo.CharAgi} Agility, and {characterInfo.CharInt} Intellect." +
                $"You also begin your journey with {characterInfo.PlayerHP} Health Points");
        }


    }
}
