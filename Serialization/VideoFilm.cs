﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class VideoFilm : CypherItem
    {
        enum GenreOfItem { comedy, action, thriller, horror, cartoon, musicle };
        public VideoFilm()
        {
        }
    }
}
