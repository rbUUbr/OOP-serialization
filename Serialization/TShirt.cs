using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class TShirt : Attributric
    {
        public enum SizeOfItem { S, XS, M, L, XL, XXL }
        public TShirt() : base()
        {

        }
    }
}
