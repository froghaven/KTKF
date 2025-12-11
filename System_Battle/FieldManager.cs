using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_DeckBuilder;



namespace System_Battle
{
    public class FieldManager
    {

         // --- Turn Management ---
         // Start Player's Turn 
         // Send Player Available Action Query Roots 
         // Recieve action query from player 
         // Parse action query 
         // Update Field / Player(s) Information
         // End Player's Turn 


         // Match Turn # 
         // P1 
         // P2 
         // P1 Formation
         // P2 Formation
         // P1 Deck 
         // P2 Deck 
         // P1 Hand 
         // P2 Hand 
         // Enviro Deck 
         // Discard Pile 

        Player P1              { get; set; }
        Deck P1_Deck           { get; set; } 
        List<Card> P1_Hand     { get; set; } 
        Formation P1_Formation { get; set; }

        Player P2              { get; set; }
        Deck P2_Deck           { get; set; }
        List<Card> P2_Hand     { get; set; }
        Formation P2_Formation { get; set; }

        Deck Pile_Enviro       { get; set; }
        Deck Pile_Discard      { get; set; }


        public FieldManager(Player player1, Player player2) 
        {
            P1 = player1;
            P1_Deck = player1.Deck;
            P1_Hand = player1.Hand;
            P1_Formation = player1.Formation;

            P2 = player2;
            P2_Deck = player2.Deck;
            P2_Hand = player2.Hand;
            P2_Formation = player2.Formation;
        }   


        public void SetupFormation()
        {

        }

        public void EditFormation()
        {

        }

        public void AddToFormation()
        {

        }
    }
}
