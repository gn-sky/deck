using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            for (int i = 0; i < deck.NumberOfCards; i++)
            {
                Console.Write("{0,-19}", deck.DealCard(i).ToString());
                if ((i + 1) % 6 == 0) Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
