using System;
using System.Collections.Generic;
using System.Text;

namespace NewExercise
{
    public class Dialogue
    {

        public static string Conversation1(int x)
        {
            if (x == 1)
            {
                Console.WriteLine("Barkeep: Aye, you must have really hit your head. This country is in the grips of Civil War. Brother killing brother, each and every one of us has been impacted." +
                    "Enough about that though, whats your name stranger?");
            }
            else if (x == 2)
            {
                Console.WriteLine("Barkeep: Ah stranger, you are in what was once the town of Bergen, Norway. Don't tell me you have come from a different land during such troubling times." +
                    "Enough about that though, whats your name stranger?");
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
