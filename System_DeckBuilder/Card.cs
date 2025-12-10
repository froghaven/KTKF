using System.Collections.Generic;
using System;


namespace DeckBuilder
{
    public class Card
    {

        public required string AbilityDescription { get; set; }
        public required string CardName { get; set; }
        public required string ArtLink { get; set; }
        public Element CardElement { get; set; }
        public Type CardType { get; set; }
        public int ATK { get; set; }
        public int HP { get; set; }
        public int Id { get; set; }

        public enum Element
        {
            Spirit,
            Nature,
            Chaos,
            Space,
            Time,
        }

        public enum Type
        {
            Item,
            King,
            Core,
            Echos,
            Beast,
            Enviro,
            Pillar,
            Noxious
        }


        public void Ability(Card target) { }
        public void Ability(List<Card> targets) { }


        // Attack 

    }
}
