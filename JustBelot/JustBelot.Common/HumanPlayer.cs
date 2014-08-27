using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
    public class HumanPlayer : IPlayer
    {
        private bool isLocal;

        public HumanPlayer(bool isLocal)
        {
            this.isLocal = isLocal; 
        }

        public bool IsLocal
        {
            get
            {
                return isLocal;
            }
        }

        public string Name
        {
            get { return "Human Player"; }
        }

        public string Points
        {
            get { throw new NotImplementedException(); }
        }

        public void PlayCard()
        {
            Console.WriteLine("Human Player played a card.");
        }
    }
}
