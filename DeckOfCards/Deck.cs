using System;

namespace DeckOfCards
{
    public class Deck
    {
        private Card[] deck;

        private int numberOfCards;
        public int NumberOfCards 
        {
            get { return numberOfCards; }
            private set { numberOfCards = value; }
        }
  
        public Deck()
        {
            numberOfCards = 52;
            deck = new Card[numberOfCards];

            var numberOfSuites = Enum.GetNames(typeof(Suite)).Length;
            var numberOfFaces = Enum.GetNames(typeof(Face)).Length;
            var cardCreated = 0;

            for (int suite = 0; suite < numberOfSuites; suite++)
            {
                for (int face = 1; face <= numberOfFaces; face++)
                {
                    deck[cardCreated] = new Card((Face)face, (Suite)suite);
                    cardCreated++;
                }
            }
        }

        public Card DealCard(int i)
        {
            if (i <= numberOfCards)
                return deck[i];
            else
                return null;
        }
    }
}
