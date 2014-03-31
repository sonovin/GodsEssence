using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class CharacterModel
    {
        public int Level;
        public string Name;
        public string Description;
        public List<Attributes> Status;
        public Position Location;
    }
}