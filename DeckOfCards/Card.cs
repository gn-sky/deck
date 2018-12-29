namespace DeckOfCards
{
    public class Card
    {
        private Face face { get; set; }
        private Suite suite { get; set; }

        public Card(Face cardFace, Suite cardSuite)
        {
            face = cardFace;
            suite = cardSuite;
        }

        public override string ToString()
        {
            return $"{face} of {suite}";
        }
    }
}