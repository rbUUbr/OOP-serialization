using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    [Serializable]
    public abstract class CypherItem : Item
    {
        public CypherItem() : base()
        {

        }
    }
}
