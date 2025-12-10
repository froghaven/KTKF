using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Battle
{
    public class Player
    {



        public int ID { get; set; }
        public int TurnNumber { get; set; }
        public Type PlayerType { get; set; }
        public Action SelectedAction { get; set; }





        public enum Type
        {
            CPU1,
            CPU2,
            CPU3,   
            Player1,
            Player2, 
            Player3,
        }
        public enum Action
        {
            Rock = 1, 
            Paper = 2, 
            Scissors = 3
        }
    }
}
