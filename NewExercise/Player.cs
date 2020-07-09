using System;

namespace NewExercise
{
    public class Player
    {

        public Player()
        {

        }


        public string PlayerChar { get; set; }
        public int PlayerHP { get; set; }
        public int PlayerCoins { get; set; }
        public string CharClass { get; set; }
        public int CharStr { get; set; }
        public int CharAgi { get; set; }
        public int CharInt { get; set; }
        public int PlayerDmg1 { get; set; }
        public int EnemyDmg1 { get; set; }
        




        public static int RandomNumber(int min, int max)
        {
            Random _random = new Random();

            return _random.Next(min, max);


        }




        public int TakeDamage(int enemyDMG1)
        {
            return PlayerHP -= enemyDMG1;
        }
        

    }





}
