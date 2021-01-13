using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace WordGame
{
    class Session
    {
        public int Level { get; set; }
        private List<Word> allWords = new List<Word>();
        
        public Session(int level)
        {
            this.Level = level;
        }

        public bool begin()
        {
            allWords.Add(new Word("aptech", "A leading global career education company."));
            allWords.Add(new Word("bank", "A financial institution licensed to receive deposits and make loans."));
            allWords.Add(new Word("yellow", "A bright color"));
            allWords.Add(new Word("bitcoin", "A currency"));


            Console.WriteLine($"Level {Level}");
            //var wordForLevel = ;

            bool passedLevel = allWords[Level - 1].displayWord();

            return passedLevel;
        }





    }
}
