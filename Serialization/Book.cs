using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Book : Item
    {
        public enum GenreOfItem { adventure, story, roman, poetry, drama, scientific, fantasy };
        public Book() : base()
        {

        }
    }
}
