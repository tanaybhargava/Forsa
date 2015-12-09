using System;
using System.Collections.Generic;

public class Deck {

	List<Card> cards;

	public Deck(List<Card> cards) {
		this.cards = cards;
	}

	public void shuffleDeck() {

		Random randomGenerator = new Random (DateTime.Now.Millisecond);
		List<Card> shuffledCards = new List<Card> ();
		
		// randomly remove cards from the one deck and put them in the copied deck
		while (cards.Count > 0)
		{
			int index = randomGenerator.Next(cards.Count);
			shuffledCards.Add(cards[index]);
			cards.RemoveAt(index);
		}
		cards = shuffledCards;
	}

	public void discardCards(int numberOfCards) {
		cards.RemoveRange (0, numberOfCards);
	}

	public Card getNextCard() {
		Card card = cards [0];
		cards.RemoveAt (0);
		return card;
	}
}
