using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System_DeckBuilder;



namespace System_Battle
{
    public class Player
    {



        public int ID { get; set; }
        public int TurnNumber { get; set; }
        public Type PlayerType { get; set; }
        public string SelectedAction { get; set; }


        public Deck Deck { get; set; }

        public List<Card> Hand {  get; set; }

        public Formation Formation { get; set; }





        public Player() { }




        public enum Type
        {
            CPU1,
            CPU2,
            CPU3,   
            Player1,
            Player2, 
            Player3,
        }
       
    }
}
