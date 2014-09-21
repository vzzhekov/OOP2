using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
   public class GameManager
    {
       private List<IPlayer> players = new List<IPlayer>();
       public GameManager(IPlayer player1, IPlayer player2, IPlayer player3, IPlayer player4)
       {
           players.Add(player1);
           players.Add(player2);
           players.Add(player3);
           players.Add(player4);

       }

       public IPlayer this[PlayerPosition position]
       {
           get
           {

               switch (position)
               {
                   case PlayerPosition.West:
                       return this.players[3];
                       
                   case PlayerPosition.East:
                       return this.players[1];
                       
                   case PlayerPosition.South:
                       return this.players[0];
                       
                   case PlayerPosition.North:
                       return this.players[2];
                       
                   default:
                       throw new ArgumentOutOfRangeException();
                       
               }       


           }
       }

    }
}
