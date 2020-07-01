using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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

            Console.WriteLine("First here is a brief description of each attribute:");
            Console.WriteLine("Strength - Determines how much damage you deal with weapons");
            Console.WriteLine("<===========================================================>");
            Console.WriteLine("Agility - Determines how many attacks you may make each turn");
            Console.WriteLine("<===========================================================>");
            Console.WriteLine("Intellect - Determines which spells you can use (some spells can only be used by the sorceror)");

            Console.WriteLine("You have 20 attribute points.");

            Console.WriteLine("How many points would you like to add to Strength?");
            int playerStr = int.Parse(Console.ReadLine());

            Console.WriteLine("How many points would you like to add to Agility?");
            var playerAgi = int.Parse(Console.ReadLine());

            Console.WriteLine("How many points would you like to add to Intellect?");
            var playerInt = int.Parse(Console.ReadLine());

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

            var battleOne = Encounter(playerStr, playerAgi);

            Console.WriteLine($"Knowing that your opponent is stronger, you seize the initiative and strike first.");
            Console.WriteLine(battleOne);

            int enemyDmg1 = RandomNumber(0, 11);

            Console.WriteLine("The man stumbles in pain, but quickly regains his footing - Ha! It will take more than that to best me!");
            Console.WriteLine($"He lashes forward with his razor sharp claws, you attempt to block his attack." +
                $"The mysterious man deals {enemyDmg1} points of dmg to you");
            Console.WriteLine();
            Console.WriteLine("The slash burns your skin, but you won't go down that easily. You strike back.");
            Console.WriteLine(battleOne);
            Console.WriteLine();
            Console.WriteLine("The mysterious man shrieks in pain. You have hurt him this time." +
                "The next thing you know the man is engulfed in smoke, you cant see him through the haze and begin swinging your weapon wildly." +
                "You hit nothing, and as the smoke dissipates you realize he has vanished.");
            //This is the first battle, and very basic.Each encounter will add more variable and more code.

          Console.WriteLine("What was he you think to yourself, and more importantly, what is going in this world." +
                "As you look down toward the smoldering town, many more questions arise, and you need answers.");
            Console.WriteLine("You make your way down to what is left of the town and notice that the inn remains somewhat intact." +
                "You make your way inside and into the pub area. The few people you see inside show signs of struggle, and all have expressions of great sorrow." +
                "You immediately approach the barkeep.");
            Console.WriteLine("Barkeep: Hello lad, he says attempting to bring out something resembling a smile.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Choose what to say by typing in the number associated with the text:");
            Console.WriteLine("1. What the hell happened here?");
            Console.WriteLine("2. Where am I? I awoke in the church and can barely remember my name.");
            Console.WriteLine("***************************************************************************");
            
            int chat1 = int.Parse(Console.ReadLine());
            Conversation1(chat1);

            Console.WriteLine("Barkeep: Is there anything else you would like to know?");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Choose what to say by typing in the number associated with the text:");
            Console.WriteLine("1. How did the fighting begin?");
            Console.WriteLine("2. Is anywhere safe?");
            Console.WriteLine("************************************************************************");

            int chat2 = int.Parse(Console.ReadLine());
            Conversation2(chat2);











        }

       

        public static string Encounter(int x, int y)
        {
            if(x >= 10 && y >= 10)
            {
                Console.WriteLine("You hit the target two times for 10 points of damage each; dealing a total of 20 damage.");
            }
            else if (x <= 10 && y >= 10)
            {
                Console.WriteLine("You hit the target two times for 5 points of damage each; dealing a total of 10 damage.");
            }
            else if (x <= 10 && y <= 10)
            {
                Console.WriteLine("You hit the target one time for 5 points of damage each; dealing a total of 5 damage.");
            }
            else if (x >= 10 && y <= 10)
            {
                Console.WriteLine("You hit the target one time for 10 points of damage each; dealing a total of 10 damage.") ;
            }
            return "You missed the target.";
        }

        private static readonly Random _random = new Random();

        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public static string Conversation1(int x)
        {
            if (x == 1)
            {
                Console.WriteLine("Barkeep: Aye, you must have really hit your head. This country is in the grips of Civil War. Brother killing brother, each and every one of us has been impacted.");
            }
            else if (x == 2)
            {
                Console.WriteLine("Barkeep: Ah stranger, you are in what was once the town of Bergen, Norway. Don't tell me you have come from a different land during such troubling times.");
            }
            return "Barkeep: Have an ale on the house, you look like you need it.";
        }
        public static string Conversation2(int x)
        {
            if (x == 1)
            {
                Console.WriteLine("Barkeep: It all began with the death of Emperor Nergal. With his death, two factions arose; the Brotherhood of Burzum," +
                    "led by Varg 'the Black Count' and the Legion of Mayhem, led by Euronymous. Both sides revel in destruction and evil, may god have mercy on this land.");
            }
            else if (x == 2)
            {
                Console.WriteLine("Barkeep: Aye, nowhere in this land. But if you can make it into the Kingdom of Finland you may be permitted asylum." +
                    "However, all the roads out of Norway have been blocked, and the bridges burned. The only way out is by boat, and it is a perilous journey.");
            }
            return "Barkeep: Is there anything else lad?";
        }
        
    }
}

