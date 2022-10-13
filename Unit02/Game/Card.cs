using System;

namespace Unit02.Game
{
        /// <summary>
        /// A small piece of cardboard with a number.
        /// 
        /// The function of a card is to present a number value to the player.
        /// </summary> 
        public class Card//creating the blueprint
        {
        public int value;
        
        
        /// <summary>
        /// Calls the method 'Roll' to randomize a new card value
        /// </summary>
        public Card()//Constructor! A method with the name of the class
        {
            Roll();
        }

        /// <summary>
        /// Sets member variable 'value' to a new value for the card.
        /// </summary>
        public void Roll()
        {
            Random random = new Random();
            value = random.Next(1, 14); // 14 is not included and will not be returned
        }
    }
}