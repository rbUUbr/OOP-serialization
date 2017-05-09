using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Game : CypherItem
    {
        enum GenreOfItem { action, rpg, rts,strategy, fighting, racing };
        public Game() : base()
        {

        }
    }

}
