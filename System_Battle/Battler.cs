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
        public Battler(Player Home, Player Away) 
        {
            // RPS for 1st Players 
            do
            {
                RockPaperScissors($"{Home.SelectedAction}", $"{Away.SelectedAction}");
            }
            while (Home.SelectedAction == Away.SelectedAction); 
            




        }

        



        public static string RockPaperScissors(string homeInput, string awayInput)
        {
            Dictionary<string, string> rpsKey = new Dictionary<string, string>()
            {
                { "rock", "paper"},
                { "scissors", "rock"},
                { "paper", "scissors"}
            };


           string outputMessage="";

           if (awayInput == homeInput) { outputMessage = "Tie!"; }
           if ( rpsKey[homeInput] == awayInput ) { outputMessage = "Away!"; }
           else if (rpsKey[awayInput] == homeInput) { outputMessage = "Home!"; }


           return outputMessage; 
        }


        public void SelectPlayer1()
        {

        }
    }
}
