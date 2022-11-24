using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    /// <summary>
    /// Class directs the game
    /// </summary>
    class Director
    {

        public Word theWord = new Word();
        private Jumper jumper = new Jumper();
        private bool isPlaying = true;
        // private bool correctness = true;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            theWord.populateHint();
            theWord.printHint();
            jumper.printJumper();

            
            while (theWord.isPlaying() && jumper._isDead != true)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
            theWord.gameOver();
        }

        /// <summary>
        /// Gathering inputs and checking guess
        /// </summary>
        private void GetInputs()
        {

            theWord.gatherGuess();
            theWord.checkLetter();

        }

        /// <summary>
        /// Doing requred updates to hint list
        /// </summary>
        private void DoUpdates()
        {
            // correctness = theWord.checkLetter();
        
            if (theWord.checkLetter())
            {
                Console.WriteLine("You got it right\n\n");
            }
            else
            {
                Console.WriteLine("You got it wrong\n\n");
                jumper.breakParachute();
            }

        }

        /// <summary>
        /// Printing jumper and word on terminal
        /// </summary>
        private void DoOutputs()
        {
            theWord.printHint();
            jumper.printJumper();

        }

    }
}


