using System;

namespace WordGame
{
    /* 
     * Given a set of letters, with a letter missing, guess the correct word and provide the missing letter.
     * A definition will be given and a timer will be used.  
     * A point is given if word is correct before timer runs out.
     * Max of 3 tries and timer automatically ends.
     * A failed level means game over.
     * 
    */
    class Program
    {
        static bool gamerIsAlive = true;
        static void Main(string[] args)
        {
            int level = 1;
            while (gamerIsAlive && level <= 4)
            {
                var session = new Session(level);
                gamerIsAlive = session.begin();
                Console.Clear();
                level++;

            }

            Console.WriteLine("Game Over");
        }
    }
}
