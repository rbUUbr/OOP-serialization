using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serialization
{
    [Serializable]

    public class Game : CypherItem
    {
        private string hardLevel;
        [XmlElement("HardLevel")]
        public string HardLevel
        {
            get
            {
                return hardLevel;
            }
            set
            {
                hardLevel = value;
            }
        }
        public Game() : base()
        {

        }
    }

}
