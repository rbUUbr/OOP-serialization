using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    [DataContract]
    public class VideoFilm : CypherItem
    {
        [DataMember]
        private string resolution;
        [XmlElement("Resolution")]
        public string Resolution
        {
            get
            {
                return resolution;
            }
            set
            {
                resolution = value;
            }
        }
        public VideoFilm() : base()
        {
        }
    }
}
