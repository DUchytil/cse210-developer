using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    /// <summary>
    /// Class directs the game
    /// </summary>
    public class Word
    {
        private string _word;
        private int _length;
        List<char> _hint = new List<char>();

        List<string> _words = new List<string>(){
            "happiness", "sadness", "thanksgiving"
        };
        char _guess;
        bool _isPlaying;

        TerminalService terminal = new TerminalService();

        /// <summary>
        /// Constructor initiates a random word for user to guess
        /// </summary>
        public Word()
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, _words.Count);
            _word = _words[randomIndex];
        }

        /// <summary>
        /// method called to populate the hint list
        /// </summary>
        public void populateHint()
        {

            _length = _word.Length;

            _hint.Add(' ');
            foreach (char character in _word)
            { 
                _hint.Add('_');
            }

            terminal.WriteText("   ");

        }

        /// <summary>
        /// Method called to pring hint list on terminal
        /// </summary>
        public void printHint()
        {

            //Printing list
            foreach (char letter in _hint)
            {
                terminal.WriteChar(letter);
            }
            terminal.WriteText("   ");
        }

        /// <summary>
        /// Method called to gather guess from user
        /// </summary>
        public void gatherGuess()
        {
            _guess = terminal.ReadCharacter("Enter a guess [a-z]: ");
        }

        /// <summary>
        /// Method called to check if guess is correct and contained in the word
        /// </summary>
        public bool checkLetter()
        {

            int indexValue = 0;
            bool correctGuess = false;

            if (_word.Contains(_guess))
            {
                correctGuess = true;
                foreach (char letter in _word)
                {
                    indexValue += 1;
                    if (letter == _guess)
                    {
                        _hint[indexValue] = _guess;
                    }
                }
            }
        return correctGuess;
        }

        /// <summary>
        /// Method called to see if all letters have been guessed or if more are remaining
        /// </summary>
        public bool isPlaying()
        {
            if (_hint.Contains('_'))
            {
                _isPlaying = true;
            }
            else
            {
                _isPlaying = false;
            }

            return _isPlaying;
        }

        /// <summary>
        /// Method called to pring game over message on terminal
        /// </summary>
        public void gameOver()
        {
            terminal.WriteText("\n\nGAME OVER");
        }

    }

}