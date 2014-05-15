using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class CharacterModel: ObjectModel
    {
        public int Level;
        public string Name;
        public string Description;
        public List<Attributes> Status;
        public Position Location;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Vitality;
        public int Wisdom;
        public int Luck;
    }
}