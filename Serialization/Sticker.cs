using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Sticker : Attributric
    {
        public Sticker() : base()
        {
        }
        public Sticker(string Size)
        {
            this.Size = Size;
        }
    }
}
