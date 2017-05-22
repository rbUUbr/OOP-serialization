using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class MusicDisc : CypherItem
    {
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