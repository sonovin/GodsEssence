﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public abstract class SkillModel
    {
        public int Level;
        public string Name;
        public string Description;
        public bool active;
        public List<Attribute> Effects;
        public abstract double Action();
    }
}