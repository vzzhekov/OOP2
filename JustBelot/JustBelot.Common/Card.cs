using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
    public struct Card
    {
        public CardColor Color { get; set; }
        public CardType Type { get; set; }

        public Card(CardColor color, CardType type) : this()
        {
            this.Color = color;
            this.Type = type; 
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Type.ToString(), Color.ToString());
        }

        public static Card operator ++(Card card)
        {
            Card newCard = new Card(card.Color, card.Type);
            if (newCard.Color != CardColor.Spades)
            {
                newCard.Color++;
            }
            else
            {
                if (newCard.Type == CardType.Ace) {
                    newCard.Type = CardType.Seven;
                newCard.Color = CardColor.Club;
                    }
                else
                {
                    newCard.Type++;
                }
            }
            
            return newCard;
        }
    }
}
