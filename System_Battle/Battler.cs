using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System_Battle.Player;



namespace System_Battle
{
    public class Battler
    {
        public Battler(Player player1, Player player2) 
        {
            // RPS for 1st Players 
            RockPaperScissors($"{player1.SelectedAction}", $"{player2.SelectedAction}");


        }



        public void RockPaperScissors(string player1Input, string player2Input)
        {
            if (player1Input == player2Input)
            {
                // Play again 
            }



        }


        public void SelectPlayer1()
        {

        }
    }
}
