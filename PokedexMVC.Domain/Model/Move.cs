using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BasicType MoveType { get; set; }
        public bool IsPhisical { get; set; }
        public int Damage { get; set; }
        public int? EffectId { get; set; }
        public virtual StatusEffect? Effect { get; set; }
        
    }
}
