using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serialization
{
    public abstract class Attributric : Item
    {
        private string size;
        [XmlElement("Size")]
        public string Size
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
