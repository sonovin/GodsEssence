using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public abstract class SkillModel
    {
        public int level;
        public string name;
        public string description;
        public bool active;
        public abstract double Action();
    }
}