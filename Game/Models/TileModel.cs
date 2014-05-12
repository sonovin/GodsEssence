using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public abstract class TileModel
    {
        public string name;
        public abstract void Affects(CharacterModel character);
        public TileModel North;
        public TileModel South;
        public TileModel West;
        public TileModel East;
    }
}