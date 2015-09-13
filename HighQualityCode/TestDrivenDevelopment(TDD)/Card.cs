namespace Poker
{
    using System;

    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            var cardToString = string.Format("{0}{1}", Face, Suit);
            return cardToString;
        }
    }
}
