using System;


namespace DeckBuilder
{


	public class Deck
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CardCount { get; set; }
		public Card King { get; set; }
		public List<Card> Items { get; set; }
		public Card[] Guardians { get; set; }
		public Card[] Environments { get; set; }
	}
}
