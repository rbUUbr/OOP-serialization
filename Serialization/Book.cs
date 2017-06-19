using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    [Serializable]
    public class Book : Item
    {
        [DataMember]
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
