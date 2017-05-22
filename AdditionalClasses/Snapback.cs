using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using System.Xml.Serialization;

namespace AdditionalClasses
{
    public class Snapback : Item
    {
        private string firm;
        [XmlElement("Firm")]
        public string Firm
        {
            get
            {
                return firm;
            }
            set
            {
                firm = value;
            }
        }
        public Snapback()
        {
        }
    }
}
