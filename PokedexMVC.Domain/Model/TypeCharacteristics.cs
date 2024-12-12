using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class TypeCharacteristics
    {   
        public int Id { get; set; }        
        public int TypeRef { get; set; }
        public BasicType Type { get; set; }
        
    }
}
