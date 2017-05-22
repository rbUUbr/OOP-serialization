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
        private string author;
        [XmlElement("Author")]
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public Book() : base()
        {

        }
    }
}
