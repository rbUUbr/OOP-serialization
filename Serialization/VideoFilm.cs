using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Serialization
{
    [Serializable]
    public class VideoFilm : CypherItem
    {
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
