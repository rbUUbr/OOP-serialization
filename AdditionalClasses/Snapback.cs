using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace AdditionalClasses
{
    [DataContract]
    public class Snapback : Item
    {
        [DataMember]
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
