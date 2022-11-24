using System;
using System.Collections.Generic;



namespace Unit03.Game
{
    /// <summary>
    /// Class directs the game
    /// </summary>
    public class Jumper
    {

        List<string> _parachute = new List<string>();

        TerminalService terminal = new TerminalService();
        int index = 1;
        public bool _isDead = false;

        /// <summary>
        /// Constructor adds elements to the parachute
        /// </summary>
        public Jumper()
        {

            //Populate entire jumper list
            _parachute.Add("     ");
            _parachute.Add(@" ___");
            _parachute.Add(@"/___\");
            _parachute.Add(@"\   /");
            _parachute.Add(@" \ /");
            _parachute.Add(@"  O");
            _parachute.Add(@" /|\");
            _parachute.Add(@" / \");            

        }

        /// <summary>
        /// Method called to print jumper on terminal
        /// </summary>
        public void printJumper()
        {
            // TerminalService.WriteText();
            foreach (var line in _parachute)
            {
                terminal.WriteText(line);
            }
        }

        /// <summary>
        /// Method called to break an index in the jumper's parachute list
        /// </summary>
        public void breakParachute()
        {

            //Write code to remove indexes from the list containing the lists of parachute components


            if (_parachute[index] != "  O")
            {
                _parachute[index] = "   ";
                index = index + 1;

            }
            if (index == 5)
            {
            _parachute[0] = "     ";
            _parachute[1] = "     ";
            _parachute[2] = "      ";
            _parachute[3] = "    ";
            _parachute[4] = "     ";
            _parachute[5] = (@"  x");
            _parachute[6] = (@" /|\");
            _parachute[7] = (@" / \");

            _isDead = true;
            }

        }

        
    }

}