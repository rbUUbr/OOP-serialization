﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    [DataContract]
    public class TShirt : Attributric
    {
        public TShirt() : base()
        {

        }
    }
}
