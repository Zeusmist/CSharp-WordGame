using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace WordGame
{
    class Word
    {
        public string Letters { get; set; }
        public string Description { get; set; }
        public char MissingLetter { get; set; }
        private int _countDown = 10;
        private static bool timeIsUp = false;

        public Word(string letters, string description)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(letters);
            int missingIndex = rnd.Next(0, letters.Length - 1);
            this.MissingLetter = letters[missingIndex];
            sb[missingIndex] = '_';
            letters = sb.ToString();
            this.Letters = letters;
            this.Description = description;
        }

        public bool displayWord()
        {
            int triesLeft = 3;
            Timer aTimer = new Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;

            while (triesLeft > 0)
            {
                Console.WriteLine($"Word: {Letters.ToUpper()}\t\tDescription: {Description}");
                Console.Write("Enter Missing Letter");
                string suppliedLetter = Console.ReadLine();
                Console.WriteLine($"{suppliedLetter.ToUpper()}");
                Console.WriteLine($"{MissingLetter.ToString().ToLower()}");
                if (suppliedLetter.ToLower() == MissingLetter.ToString().ToLower())
                {
                    timeIsUp = true;
                    return true;
                }
                else
                {
                    triesLeft--;
                    Console.WriteLine($"You have {triesLeft} tries left");
                }
            }
            return false;
        }

        void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (!timeIsUp)
            {
                if (!(_countDown-- < 0))
                {
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine(_countDown + " seconds left");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Time is up!");
                    timeIsUp = true;
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    switch (keyInfo)
                    {
                        default:
                            Environment.Exit(1);
                            break;
                    }
                }

            }

        }


    }
}
