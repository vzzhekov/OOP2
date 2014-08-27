using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBelot.Common;

namespace JustBelot.VilianAI
{
    public class Player : IPlayer
    {
        public string Name
        {
            get { return "Vilian bot"; }
        }

        public string Points
        {
            get { throw new NotImplementedException(); }
        }

        public void PlayCard()
        {
            var helper = new PlayHelper();
            helper.MakeDecision();
            Console.WriteLine("VilianAI Played a card.");
        }
    }
}
