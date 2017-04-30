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
        enum GenreOfMusic { bluzz, raggy , rap, rock, metal };
        public MusicDisc() 
        {
        }

    }
}