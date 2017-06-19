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
    public class MusicDisc : CypherItem
    {
        [DataMember]
        private string albumType;
        [XmlElement("AlbumType")]
        public string AlbumType
        {
            get
            {
                return albumType;
            }
            set
            {
                albumType = value;
            }
        }
        public MusicDisc() 
        {
        }

    }
}