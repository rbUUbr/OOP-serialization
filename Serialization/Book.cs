using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    class Book : Item
    {
        enum Genre { adventure, story, roman, poetry, drama, scientific, fantasy };
        private int genreOfBook;
        public Book()
        {
        }
        public int GenreOfBook
        {
            get
            {
                return genreOfBook;
            }
            set
            {
                genreOfBook = value;
            }
        }
    }
}
