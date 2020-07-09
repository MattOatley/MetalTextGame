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
            Player characterInfo = new Player();
            
            Introduction.Intro();

            characterInfo.PlayerChar = Console.ReadLine();

            Introduction introduction = new Introduction();

            introduction.CharacterCreation();

            //TODO Finish the intro class and begin working on chapter 1 class text.

            Console.WriteLine($"You grip your weapon tightly as you brace yourself for whatever lies outside of the church." +
                $"You are {characterInfo.PlayerChar}, and you will become a powerful {characterInfo.CharClass}." +
                $"As you make your way outside you realize that the rest of the town lies in ruin as well." +
                $"You begin to hope that you have what it takes to face the trials that lie ahead...");
            Console.Write($"Press Enter To Continue:");
            Console.ReadLine();

            Console.WriteLine($"As you step outside a full moon looms overhead, partially obscured by the smoke still rising from the smoldering town." +
                $"You hear a twig snap on the side of the church and you realize that you are not alone." +
                $"You see a shadowy figure appear next to the building - Well well well, what do we have here, a half dead {characterInfo.CharClass}? This should be easy.");
            Console.Write($"Press Enter To Continue:");
            Console.ReadLine();

            Console.WriteLine("The figure emerges from the shadows, it is a man, but not fully human, he has long black hair, and long fingernails as sharp as razorblades." +
                "You have no choice, it is time to fight, you unsheath your weapon and the man smirks - Ah, he still has a little fight in him." +
                "Good! The meal is always more satisfying when it puts up a fight.");

            var battleOne = Battle.Encounter(characterInfo.CharStr, characterInfo.CharAgi);

            Console.WriteLine("Knowing that your opponent is stronger, you decide to seize the initiative and strike first.");
            Console.Write("Press Enter To Attack:");
            Console.ReadLine();
            Console.WriteLine(battleOne);
            //DONE
            //Add some player options here, Huge wall of text is no fun.
            //DONE

            characterInfo.PlayerDmg1 = Player.RandomNumber(0, 16);
            characterInfo.EnemyDmg1 = Player.RandomNumber(0, 11);

            //Work on above damage model for player and enemy damage.
            //Damage model coming along, still needs quite a bit of work.

            Console.WriteLine("The man stumbles in pain, but quickly regains his footing - Ha! It will take more than that to best me!");
            Console.Write("Press Enter To Continue:");
            Console.ReadLine();
            Console.WriteLine($"He lashes forward with his razor sharp claws, you attempt to block his attack." +
                $"The mysterious man deals {characterInfo.EnemyDmg1} points of dmg to you");
            Console.WriteLine($"After dealing {characterInfo.EnemyDmg1} damage, you are left with {characterInfo.TakeDamage(characterInfo.EnemyDmg1)}HP");
            Console.Write("Press Enter To Continue:");
            Console.ReadLine();
            Console.WriteLine("The slash burns your skin, but you won't go down that easily. You strike back.");
            Console.WriteLine(battleOne);
            
            Console.Write("Press Enter To Continue:");
            Console.ReadLine();
            Console.WriteLine("The mysterious man shrieks in pain. You have hurt him this time." +
                "The next thing you know the man is engulfed in smoke, you cant see him through the haze and begin swinging your weapon wildly." +
                "You hit nothing, and as the smoke dissipates you realize he has vanished.");
            Console.WriteLine("CONGRATULATIONS!! YOU ARE VICTORIOUS!!");
            //This is the first battle, and very basic.Each encounter will add more variable and more code.


            Console.Write("Press Enter To Continue:");
            Console.ReadLine();
            Console.WriteLine("What was he you think to yourself, and more importantly, what is going in this world." +
                "As you look down toward the smoldering town, many more questions arise, and you need answers.");
            Console.WriteLine("You make your way down to what is left of the town and notice that the inn remains somewhat intact." +
                "You make your way inside and into the pub area. The few people you see inside show signs of struggle, and all have expressions of great sorrow." +
                "You immediately approach the barkeep.");
            Console.Write("Press Enter To Continue:");
            Console.ReadLine();
            Console.WriteLine("Barkeep: Hello lad, he says attempting to bring out something resembling a smile.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Choose what to say by typing in the number associated with the text:");
            Console.WriteLine("1. What the hell happened here?");
            Console.WriteLine("2. Where am I? I awoke in the church and can barely remember my name.");
            Console.WriteLine("***************************************************************************");
            
            int chat1 = int.Parse(Console.ReadLine());
            Dialogue.Conversation1(chat1);
            Console.WriteLine(characterInfo.PlayerChar);

            Console.WriteLine($"Barkeep: A pleasure to meet you {characterInfo.PlayerChar}, I know everyone in this town, and you arent from here, thats for sure. " +
                $"Is there anything else you would like to know?");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Choose what to say by typing in the number associated with the text:");
            Console.WriteLine("1. How did the fighting begin?");
            Console.WriteLine("2. Is anywhere safe?");
            Console.WriteLine("************************************************************************");

            int chat2 = int.Parse(Console.ReadLine());
            Dialogue.Conversation2(chat2);

            Console.WriteLine($"Barkeep: Good luck on your journey {characterInfo.PlayerChar}. Take these coins with you, its not much but I have a feeling that I should help you stranger.");

            characterInfo.PlayerCoins = 100;

            Console.WriteLine($"You recieve {characterInfo.PlayerCoins} Gold Coins.");

            Console.WriteLine("You thank the Barkeep and head back out into the ruins of the town. The sun is beginning to rise, and the smoke has faded." +
                "As you look down at the embers of a nearby building you decide to head east. Unsure of where the journey will take you, you are prepared for anything.");











        }

       

       

       
        

       
        
    }
}

