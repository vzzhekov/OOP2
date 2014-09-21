using JustBelot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBelot.VilianAI;

namespace JustBelot.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player = new HumanPlayer();
            IPlayer bot1 = new DummyPlayer();
            IPlayer bot2 = new DummyPlayer();
            IPlayer bot3 = new DummyPlayer();
            GameManager game = new GameManager(player,bot1,bot2,bot3);
            Console.WriteLine(game[PlayerPosition.West].Name);
            Console.WriteLine(game[PlayerPosition.South].Name);

            Card card = new Card(CardColor.Spades, CardType.Ace);
            Console.WriteLine(card);
            card++;
            Console.WriteLine(card);
            

        }
    }
}
