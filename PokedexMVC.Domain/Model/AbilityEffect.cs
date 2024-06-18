using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class AbilityEffect
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Mechanism { get; set; }
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
        
    }
}
