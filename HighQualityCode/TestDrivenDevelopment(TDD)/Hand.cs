namespace Poker
{
    using System;

    using System.Collections.Generic;

    using System.Text;

    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var handToString = new StringBuilder();
            handToString.AppendFormat("[" + string.Join(", ", Cards) + "]");
            return handToString.ToString();
        }
    }
}
