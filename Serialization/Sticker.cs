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
        public Sticker(string name, float cost, int quality, int genre, int count, int size, int yearOfCreate, DateTime publishDate)
        {
            this.Name = name;
            this.Cost = cost;
            this.Quality = quality;
            this.Count = count;
            this.Genre = genre;

        }
    }
}
