﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class Attributes
    {
        public enum Attribute
        {
            DEAD = -1,
            NONE = 0,
            BURNING = 1,
            FROST_BITE = 2,
            PARALYSIS = 3,
            POISON = 4,
            BLIND = 5
        };
        public Attribute Effect;
    }
}