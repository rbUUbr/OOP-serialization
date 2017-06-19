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
    public class Souvenir : Item
    {
        [DataMember]
        private string material;
        [XmlElement("Material")]
        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }
        public Souvenir()
        {
        }
    }
}
