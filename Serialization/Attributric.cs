using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public abstract class Attributric : Item
    {
        enum SizeOfItem { }
        enum GenreOfItem { cartoons, games, programming, films, anime, companies };
        private int size;
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
    }
}
