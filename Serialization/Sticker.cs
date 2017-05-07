using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Sticker : Attributric
    {
        enum GenreOfItem { cartoons, games, programming, films, anime, companies };
        public Sticker()
        {
        }
    }
}
