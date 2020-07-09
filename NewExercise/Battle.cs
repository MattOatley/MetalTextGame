using System;
using System.Collections.Generic;
using System.Text;

namespace NewExercise
{
    public class Battle
    {

        public static string Encounter(int x, int y)
        {
            if (x >= 10 && y >= 10)
            {
                Console.WriteLine("You hit the target two times for 10 points of damage each; dealing a total of 20 damage.");
            }
            else if (x <= 10 && y >= 10)
            {
                Console.WriteLine("You hit the target two times for 5 points of damage each; dealing a total of 10 damage.");
            }
            else if (x <= 10 && y <= 10)
            {
                Console.WriteLine("You hit the target one time for 5 points of damage; dealing a total of 5 damage.");
            }
            else if (x >= 10 && y <= 10)
            {
                Console.WriteLine("You hit the target one time for 10 points of damage; dealing a total of 10 damage.");
            }
            return "You missed the target.";
        }

    }
}
