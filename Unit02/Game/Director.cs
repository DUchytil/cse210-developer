using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// Class directs the game
    /// </summary>
    public class Director
    {
        bool _isPlaying = true;
        int _totalScore = 0;
        public int _firstCardValue;
        public int _secondCardValue;
        public string _choice;
        public bool _correct;
        public bool _firstTimePlaying = true; 

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            _totalScore = 300;

            Card firstCard = new Card();
            _firstCardValue = firstCard.value;

            Card secondCard = new Card();
            _secondCardValue = secondCard.value;
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Displays first card value and asks the user if they want to guess higher or lower
        /// </summary>
        public void GetInputs()
        {
            
            if (!_firstTimePlaying)
            {
                Console.Write("Play again? [y/n] ");
                _choice = Console.ReadLine();
                if (_choice == "n")
                {
                    Console.WriteLine("\nGoodbye");
                    _isPlaying = false;
                    return;
                }

            }
            
            Console.WriteLine($"\n\n\nThe card is {_firstCardValue}");
            Console.Write("Higher or lower? ");
            _choice = Console.ReadLine();

            _firstTimePlaying = false;
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {

            if (_isPlaying == false)
            {
                return;
            }

            if (_choice == "h")
            {
                if (_secondCardValue > _firstCardValue)
                {
                    _totalScore += 100;
                    _correct = true;
                }
                else
                {
                    _totalScore += -75;
                    _correct = false;
                }
            }

            else if (_choice == "l")
            {
                if (_secondCardValue < _firstCardValue)
                {
                    _totalScore += 100;
                    _correct = true;
                }
                else
                {
                    _totalScore += -75;
                    _correct = false;
                }
            }
            else
            {
                Console.Write("Error. Invalid input.");
            }

        }

        /// <summary>
        /// Displays the second card value and the palyer's total score.
        /// </summary>
        public void DoOutputs()
        {

            if (_isPlaying == false)
            {
                return;
            }

            Console.WriteLine($"Next card was: {_secondCardValue}");

            Console.WriteLine($"Your score is {_totalScore}");

            DrawNewCard();

            if (_totalScore <= 0)
            {
                Console.WriteLine("I'm sorry, you lost the game");
                _isPlaying = false;
            }

        }


        /// <summary>
        /// Draws a new card and updates the card values
        /// </summary>
        public void DrawNewCard()
        {
            Card firstCard = new Card();

            _firstCardValue = firstCard.value;

            Card secondCard = new Card();
            _secondCardValue = secondCard.value;

            _isPlaying = (_totalScore > 0);
        }
    }
}


